using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace VHF_TX_Controller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private FM_TX_DEV Device = new FM_TX_DEV();
        private DateTime localDate = DateTime.Now;

        private void printlineTimestamped(RichTextBox textbox, string line)
        {
            this.localDate = DateTime.Now;
            textbox.AppendText(localDate.ToString("HH:mm:ss.ff: ", System.Globalization.DateTimeFormatInfo.InvariantInfo));
            textbox.AppendText(line);
            textbox.AppendText(Environment.NewLine);
            textbox.ScrollToCaret();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.baudrate_combobox.SelectedIndex = this.baudrate_combobox.FindStringExact("57600");
            this.stopbits_combobox.SelectedIndex = this.stopbits_combobox.FindStringExact("One");
            this.parity_combobox.SelectedIndex = this.parity_combobox.FindStringExact("None");
            this.rfmode_comboBox.SelectedIndex = this.rfmode_comboBox.FindStringExact("DAC0-Off");

            this.DAC1f_TextBox.Text = this.GetDAC1Freq().ToString();
            this.phInc_textbox.Text = this.GetDAC0Freq().ToString();
            this.mixed_TextBox.Text = (this.GetDAC1Freq() + this.GetDAC0Freq()).ToString();
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // if (e.Type == ScrollEventType.EndScroll) // future usage ?
        }

        private double GetDAC1Freq()
        {
            // DAC to VCO chain control : 16b AD5761 + MAX2606:680nH
            // DAC delta_v = VoutMAX/ctr_word_max = 5000 mV/(2^16-1) = 0.076294 mV
            // DAC voltage = delta_v * input word

            // MAX 2606 has range of controlled frequency 0.4V - 2.4V (but handles 5V)
            // Measured:
            // 0.4V   => 68.69 MHz
            // 0.6V   => 70.84 MHz
            // 0.625V => 70.935 MHz
            // 1.85V  => 74.99 MHz           
            // 2.4V   => 82.38 MHz
            //
            // so, MAX 2606 has relation between fout = func(ftune) aproximable as
            // y = -1.6608*x^2 + 11.451*x + 64.448
            //
            // Note that calculation is just estimation

            double delta_v = 0.076294;
            double volt = (double)this.volt_hScrollBar.Value * delta_v;
            this.volt_textBox.Text = volt.ToString();

            double voltV = (double)volt / 1000;
            double freqcalc = (-1.6608 * (voltV * voltV)) + (11.451 * voltV) + 64.448;

            return freqcalc;
        }

        private float GetDAC0Freq()
        {
            // 25b phase width, 120MHz fclk DDS control
            // delta_v = fclk/phase width = (120*10e6 Hz)(2^25-1) = 3.576279Hz
            // div_10kHz used to divide frequency in Hz into tens of kHz
            // DDS frequency calculation: f = delta_v * phInc
            // Calculation is digititally precise value => calc should meet real value
            double delta_f = 3.576279, div_10kHz = 10000;
            //int ifreq = (int)(((double)this.phInc_hScrollBar.Value * delta_f) / div_10kHz);
            //int ifreq = (int)(((double)this.phInc_hScrollBar.Value * delta_f) / div_10kHz);
            double freq =((float)this.phInc_hScrollBar.Value) * delta_f/ 1e6;

            return (float)freq;
        }

        private void phInc_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.phInc_textbox.Text = this.GetDAC0Freq().ToString();
            this.mixed_TextBox.Text = (this.GetDAC0Freq() + this.GetDAC1Freq()).ToString();
            //if (e.Type == ScrollEventType.EndScroll) ; // left for furture usage
        }

        private void volt_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.DAC1f_TextBox.Text = GetDAC1Freq().ToString();
            this.mixed_TextBox.Text = (this.GetDAC0Freq() + this.GetDAC1Freq()).ToString();
            //if (e.Type == ScrollEventType.EndScroll) ; // left for furture usage
        }
        private void ausc_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            // if (e.Type == ScrollEventType.EndScroll) ; // left for furture usage

        }

        private void COM_combobox_Clicked(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            for (int index = 0; index < this.COM_combobox.Items.Count; index++)
            {
                this.COM_combobox.Items.RemoveAt(index);
            }
            this.COM_combobox.Items.Clear();
            this.COM_combobox.Items.AddRange(ports);
        }

        private void COMConnectDisconnect_btn_Click(object sender, EventArgs e)
        {
            if (this.COM_combobox.Text != "")
            {
                if (!this.Device.IsOpen)
                {
                    this.Device.PortName = this.COM_combobox.Text;
                    this.Device.BaudRate = Int32.Parse(this.baudrate_combobox.Text);
                    this.Device.ReadTimeout = Int32.Parse(this.RxTimeout_textedit.Text);
                    this.Device.WriteTimeout = Int32.Parse(this.TxTimeout_textedit.Text);
                    this.Device.Parity = this.Device.ParseParity(this.parity_combobox.Text);
                    this.Device.StopBits = this.Device.ParseStopBits(this.stopbits_combobox.Text);

                    this.Device.Open();

                    if (this.Device.IsOpen)
                    {
                        this.COMState_label.Text = "Connected";
                        this.printlineTimestamped(ComLog, this.Device.PortName + " Connected");
                    }
                }
                else
                {
                    this.Device.Close();
                    if (!Device.IsOpen)
                    {
                        this.COMState_label.Text = "Disconnected";
                        this.printlineTimestamped(this.ComLog, this.Device.PortName + " Disconnected");
                    }
                }
            }

        }

        private void sendValues_btn_Click(object sender, EventArgs e)
        {
            if (this.Device.IsOpen)
            {
                string strPhInc = this.Device.cmdFM_TX_setDAC0phIncrement(this.phInc_hScrollBar.Value);
                this.printlineTimestamped(this.ComLog, strPhInc);
                string strVolt = this.Device.cmdFM_TX_setDAC1Voltage(this.volt_hScrollBar.Value);
                this.printlineTimestamped(this.ComLog, strVolt);
                string strAudSrc = this.Device.cmdFM_TX_setRFMode(this.rfmode_comboBox.SelectedIndex);
                this.printlineTimestamped(this.ComLog, strAudSrc);

            }
        }

        private void tick_btn_Click(object sender, EventArgs e)
        {

            UInt32 tick = this.Device.cmdFM_TX_getSystemTick();

            if (tick != 0)
            {
                float tick_seconds = (float)tick / 1000;
                this.tick_TextBox.Text = tick_seconds.ToString();
                string hexRes = tick.ToString("X").PadLeft(8, '0');
                string result = "TC_GT_00000000" + " = RX: TCK: " + hexRes;
                this.printlineTimestamped(this.ComLog, result);
            }

        }

        private void phIncSend_btn_Click(object sender, EventArgs e)
        {
            string strPhInc = this.Device.cmdFM_TX_setDAC0phIncrement(this.phInc_hScrollBar.Value);
            this.printlineTimestamped(this.ComLog, strPhInc);
        }

        private void voltSend_btn_Click(object sender, EventArgs e)
        {
            string strVolt = this.Device.cmdFM_TX_setDAC1Voltage(this.volt_hScrollBar.Value);
            this.printlineTimestamped(this.ComLog, strVolt);
        }

        private void rfmdSend_btn_Click(object sender, EventArgs e)
        {
            string strAudSrc = this.Device.cmdFM_TX_setRFMode(this.rfmode_comboBox.SelectedIndex);
            this.printlineTimestamped(this.ComLog, strAudSrc);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.phInc_hScrollBar.SmallChange = (int)this.phinc_numericUpDown.Value;
            this.phInc_hScrollBar.LargeChange = (int)this.phinc_numericUpDown.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.volt_hScrollBar.SmallChange = (int)this.volt_numericUpDown.Value;
            this.volt_hScrollBar.LargeChange = (int)this.volt_numericUpDown.Value;
        }

        private void defaultInc_btn_Click(object sender, EventArgs e)
        {
            this.volt_numericUpDown.Value = 13;
            this.phinc_numericUpDown.Value = 277;
        }
    }
}
