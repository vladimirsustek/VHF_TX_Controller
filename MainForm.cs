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

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            this.COM_combobox.Items.AddRange(ports);
            this.baudrate_combobox.SelectedIndex = this.baudrate_combobox.FindStringExact("57600");
            this.stopbits_combobox.SelectedIndex = this.stopbits_combobox.FindStringExact("One");
            this.parity_combobox.SelectedIndex = this.parity_combobox.FindStringExact("None");

            double delta_f = 3.576279, div_10kHz = 10000, div_MHz = 100;
            int ifreq = (int)(((double)this.phInc_hScrollBar.Value * delta_f) / div_10kHz);
            float freq = (float)ifreq / 100;
            this.phInc_textbox.Text = freq.ToString();

            double delta_v = 0.076294;
            double ivolt = (double)this.volt_hScrollBar.Value * delta_v;
            int volt = (int)ivolt;
            this.volt_textBox.Text = volt.ToString();

            double voltV = (double)volt / 1000;
            double freqcalc = (-1.6608 * (voltV * voltV)) + (11.451 * voltV) + 64.448;
            this.DAC1f_TextBox.Text = freqcalc.ToString();

            this.volt_textBox.Text = volt.ToString();
            this.phInc_textbox.Text = freq.ToString();
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll)
            {
            }
        }

        private void phInc_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            double delta_f = 3.576279, div_10kHz = 10000, div_MHz = 100;
            int ifreq = (int)(((double)this.phInc_hScrollBar.Value * delta_f) / div_10kHz);
            float freq = (float)ifreq / 100;
            this.phInc_textbox.Text = freq.ToString();

            if (e.Type == ScrollEventType.EndScroll)
            {
            }
        }

        private void volt_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            double delta_v = 0.076294;
            double ivolt = (double)this.volt_hScrollBar.Value * delta_v;
            int volt = (int)ivolt;
            this.volt_textBox.Text = volt.ToString();

            double voltV = (double)volt / 1000;
            double freqcalc = (-1.6608 * (voltV * voltV)) + (11.451 * voltV) + 64.448;
            this.DAC1f_TextBox.Text = freqcalc.ToString();

            if (e.Type == ScrollEventType.EndScroll)
            {
            }
        }
        private void ausc_hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll)
            {
            }
        }

        private void COM_combobox_Clicked(object sender, EventArgs e)
        {
            for (int index = 0; index < this.COM_combobox.Items.Count; index++)
            {
                this.COM_combobox.Items.RemoveAt(index);
            }

            string[] ports = SerialPort.GetPortNames();
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
                string strAudSrc = this.Device.cmdFM_TX_setAudioSource(this.ausc_hScrollBar.Value);
                this.printlineTimestamped(this.ComLog, strAudSrc);

            }
        }

        private void tick_btn_Click(object sender, EventArgs e)
        {
            if (this.Device.IsOpen)
            {
                string strTick = this.Device.cmdFM_TX_getSystemTick();

                if (strTick.Contains("TCK"))
                {
                    string[] split = strTick.Split(':');
                    if (split.Length == 3)
                    {
                        int tick = Convert.ToInt32(split[2], 16);
                        float tick_seconds = (float)tick / 1000;
                        this.tick_TextBox.Text = tick_seconds.ToString();
                    }
                }
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

        private void auscSend_btn_Click(object sender, EventArgs e)
        {
            string strAudSrc = this.Device.cmdFM_TX_setAudioSource(this.ausc_hScrollBar.Value);
            this.printlineTimestamped(this.ComLog, strAudSrc);
        }
    }
}
