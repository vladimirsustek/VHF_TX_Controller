namespace VHF_TX_Controller
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.phInc_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.volt_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.ausc_hScrollBar = new System.Windows.Forms.HScrollBar();
            this.ComLog = new System.Windows.Forms.RichTextBox();
            this.COM_groupbox = new System.Windows.Forms.GroupBox();
            this.COMState_label = new System.Windows.Forms.Label();
            this.COMstinfo_label = new System.Windows.Forms.Label();
            this.COMConnectDisconnect_btn = new System.Windows.Forms.Button();
            this.RxTimeoutUnit_label = new System.Windows.Forms.Label();
            this.TxTimeoutUnit_label = new System.Windows.Forms.Label();
            this.RxTimeout_textedit = new System.Windows.Forms.TextBox();
            this.TxTimeout_textedit = new System.Windows.Forms.TextBox();
            this.RxTimeout_label = new System.Windows.Forms.Label();
            this.TxTimeout_label = new System.Windows.Forms.Label();
            this.parity_label = new System.Windows.Forms.Label();
            this.stopbits_label = new System.Windows.Forms.Label();
            this.baudrate_label = new System.Windows.Forms.Label();
            this.COM_label = new System.Windows.Forms.Label();
            this.parity_combobox = new System.Windows.Forms.ComboBox();
            this.stopbits_combobox = new System.Windows.Forms.ComboBox();
            this.baudrate_combobox = new System.Windows.Forms.ComboBox();
            this.COM_combobox = new System.Windows.Forms.ComboBox();
            this.Commands = new System.Windows.Forms.GroupBox();
            this.tick_label = new System.Windows.Forms.Label();
            this.DAC1_lab = new System.Windows.Forms.Label();
            this.DAC1f_TextBox = new System.Windows.Forms.TextBox();
            this.tick_TextBox = new System.Windows.Forms.TextBox();
            this.auscSend_btn = new System.Windows.Forms.Button();
            this.voltSend_btn = new System.Windows.Forms.Button();
            this.phIncSend_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DAC1_lab2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.volt_textBox = new System.Windows.Forms.TextBox();
            this.phInc_textbox = new System.Windows.Forms.TextBox();
            this.tick_btn = new System.Windows.Forms.Button();
            this.sendValues_btn = new System.Windows.Forms.Button();
            this.COM = new System.IO.Ports.SerialPort(this.components);
            this.mixed_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.COM_groupbox.SuspendLayout();
            this.Commands.SuspendLayout();
            this.SuspendLayout();
            // 
            // phInc_hScrollBar
            // 
            this.phInc_hScrollBar.LargeChange = 2796;
            this.phInc_hScrollBar.Location = new System.Drawing.Point(9, 47);
            this.phInc_hScrollBar.Maximum = 11184810;
            this.phInc_hScrollBar.Name = "phInc_hScrollBar";
            this.phInc_hScrollBar.Size = new System.Drawing.Size(211, 17);
            this.phInc_hScrollBar.SmallChange = 2796;
            this.phInc_hScrollBar.TabIndex = 0;
            this.phInc_hScrollBar.Value = 5899957;
            this.phInc_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.phInc_hScrollBar_Scroll);
            // 
            // volt_hScrollBar
            // 
            this.volt_hScrollBar.LargeChange = 13;
            this.volt_hScrollBar.Location = new System.Drawing.Point(9, 85);
            this.volt_hScrollBar.Maximum = 39321;
            this.volt_hScrollBar.Name = "volt_hScrollBar";
            this.volt_hScrollBar.Size = new System.Drawing.Size(211, 17);
            this.volt_hScrollBar.SmallChange = 13;
            this.volt_hScrollBar.TabIndex = 1;
            this.volt_hScrollBar.Value = 8191;
            this.volt_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volt_hScrollBar_Scroll);
            // 
            // ausc_hScrollBar
            // 
            this.ausc_hScrollBar.LargeChange = 1;
            this.ausc_hScrollBar.Location = new System.Drawing.Point(9, 125);
            this.ausc_hScrollBar.Maximum = 1;
            this.ausc_hScrollBar.Name = "ausc_hScrollBar";
            this.ausc_hScrollBar.Size = new System.Drawing.Size(81, 17);
            this.ausc_hScrollBar.TabIndex = 2;
            this.ausc_hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ausc_hScrollBar_Scroll);
            // 
            // ComLog
            // 
            this.ComLog.Location = new System.Drawing.Point(386, 32);
            this.ComLog.Name = "ComLog";
            this.ComLog.Size = new System.Drawing.Size(302, 380);
            this.ComLog.TabIndex = 3;
            this.ComLog.Text = "";
            // 
            // COM_groupbox
            // 
            this.COM_groupbox.Controls.Add(this.COMState_label);
            this.COM_groupbox.Controls.Add(this.COMstinfo_label);
            this.COM_groupbox.Controls.Add(this.COMConnectDisconnect_btn);
            this.COM_groupbox.Controls.Add(this.RxTimeoutUnit_label);
            this.COM_groupbox.Controls.Add(this.TxTimeoutUnit_label);
            this.COM_groupbox.Controls.Add(this.RxTimeout_textedit);
            this.COM_groupbox.Controls.Add(this.TxTimeout_textedit);
            this.COM_groupbox.Controls.Add(this.RxTimeout_label);
            this.COM_groupbox.Controls.Add(this.TxTimeout_label);
            this.COM_groupbox.Controls.Add(this.parity_label);
            this.COM_groupbox.Controls.Add(this.stopbits_label);
            this.COM_groupbox.Controls.Add(this.baudrate_label);
            this.COM_groupbox.Controls.Add(this.COM_label);
            this.COM_groupbox.Controls.Add(this.parity_combobox);
            this.COM_groupbox.Controls.Add(this.stopbits_combobox);
            this.COM_groupbox.Controls.Add(this.baudrate_combobox);
            this.COM_groupbox.Controls.Add(this.COM_combobox);
            this.COM_groupbox.Location = new System.Drawing.Point(11, 32);
            this.COM_groupbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.COM_groupbox.Name = "COM_groupbox";
            this.COM_groupbox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.COM_groupbox.Size = new System.Drawing.Size(343, 151);
            this.COM_groupbox.TabIndex = 4;
            this.COM_groupbox.TabStop = false;
            this.COM_groupbox.Text = "COM settings";
            // 
            // COMState_label
            // 
            this.COMState_label.AutoSize = true;
            this.COMState_label.Location = new System.Drawing.Point(227, 127);
            this.COMState_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.COMState_label.Name = "COMState_label";
            this.COMState_label.Size = new System.Drawing.Size(53, 13);
            this.COMState_label.TabIndex = 39;
            this.COMState_label.Text = "Unknown";
            // 
            // COMstinfo_label
            // 
            this.COMstinfo_label.AutoSize = true;
            this.COMstinfo_label.Location = new System.Drawing.Point(184, 127);
            this.COMstinfo_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.COMstinfo_label.Name = "COMstinfo_label";
            this.COMstinfo_label.Size = new System.Drawing.Size(35, 13);
            this.COMstinfo_label.TabIndex = 38;
            this.COMstinfo_label.Text = "State:";
            // 
            // COMConnectDisconnect_btn
            // 
            this.COMConnectDisconnect_btn.Location = new System.Drawing.Point(186, 88);
            this.COMConnectDisconnect_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.COMConnectDisconnect_btn.Name = "COMConnectDisconnect_btn";
            this.COMConnectDisconnect_btn.Size = new System.Drawing.Size(116, 24);
            this.COMConnectDisconnect_btn.TabIndex = 16;
            this.COMConnectDisconnect_btn.Text = "Connect/Disconnect";
            this.COMConnectDisconnect_btn.UseVisualStyleBackColor = true;
            this.COMConnectDisconnect_btn.Click += new System.EventHandler(this.COMConnectDisconnect_btn_Click);
            // 
            // RxTimeoutUnit_label
            // 
            this.RxTimeoutUnit_label.AutoSize = true;
            this.RxTimeoutUnit_label.Location = new System.Drawing.Point(305, 57);
            this.RxTimeoutUnit_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RxTimeoutUnit_label.Name = "RxTimeoutUnit_label";
            this.RxTimeoutUnit_label.Size = new System.Drawing.Size(20, 13);
            this.RxTimeoutUnit_label.TabIndex = 37;
            this.RxTimeoutUnit_label.Text = "ms";
            // 
            // TxTimeoutUnit_label
            // 
            this.TxTimeoutUnit_label.AutoSize = true;
            this.TxTimeoutUnit_label.Location = new System.Drawing.Point(305, 24);
            this.TxTimeoutUnit_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxTimeoutUnit_label.Name = "TxTimeoutUnit_label";
            this.TxTimeoutUnit_label.Size = new System.Drawing.Size(20, 13);
            this.TxTimeoutUnit_label.TabIndex = 36;
            this.TxTimeoutUnit_label.Text = "ms";
            // 
            // RxTimeout_textedit
            // 
            this.RxTimeout_textedit.Location = new System.Drawing.Point(245, 54);
            this.RxTimeout_textedit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RxTimeout_textedit.Name = "RxTimeout_textedit";
            this.RxTimeout_textedit.Size = new System.Drawing.Size(56, 20);
            this.RxTimeout_textedit.TabIndex = 35;
            this.RxTimeout_textedit.Text = "100";
            // 
            // TxTimeout_textedit
            // 
            this.TxTimeout_textedit.Location = new System.Drawing.Point(245, 22);
            this.TxTimeout_textedit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxTimeout_textedit.Name = "TxTimeout_textedit";
            this.TxTimeout_textedit.Size = new System.Drawing.Size(56, 20);
            this.TxTimeout_textedit.TabIndex = 24;
            this.TxTimeout_textedit.Text = "100";
            // 
            // RxTimeout_label
            // 
            this.RxTimeout_label.AutoSize = true;
            this.RxTimeout_label.Location = new System.Drawing.Point(181, 57);
            this.RxTimeout_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RxTimeout_label.Name = "RxTimeout_label";
            this.RxTimeout_label.Size = new System.Drawing.Size(61, 13);
            this.RxTimeout_label.TabIndex = 34;
            this.RxTimeout_label.Text = "Rx Timeout";
            // 
            // TxTimeout_label
            // 
            this.TxTimeout_label.AutoSize = true;
            this.TxTimeout_label.Location = new System.Drawing.Point(181, 24);
            this.TxTimeout_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxTimeout_label.Name = "TxTimeout_label";
            this.TxTimeout_label.Size = new System.Drawing.Size(60, 13);
            this.TxTimeout_label.TabIndex = 32;
            this.TxTimeout_label.Text = "Tx Timeout";
            // 
            // parity_label
            // 
            this.parity_label.AutoSize = true;
            this.parity_label.Location = new System.Drawing.Point(17, 129);
            this.parity_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.parity_label.Name = "parity_label";
            this.parity_label.Size = new System.Drawing.Size(33, 13);
            this.parity_label.TabIndex = 30;
            this.parity_label.Text = "Parity";
            // 
            // stopbits_label
            // 
            this.stopbits_label.AutoSize = true;
            this.stopbits_label.Location = new System.Drawing.Point(11, 93);
            this.stopbits_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stopbits_label.Name = "stopbits_label";
            this.stopbits_label.Size = new System.Drawing.Size(46, 13);
            this.stopbits_label.TabIndex = 29;
            this.stopbits_label.Text = "StopBits";
            // 
            // baudrate_label
            // 
            this.baudrate_label.AutoSize = true;
            this.baudrate_label.Location = new System.Drawing.Point(6, 59);
            this.baudrate_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baudrate_label.Name = "baudrate_label";
            this.baudrate_label.Size = new System.Drawing.Size(55, 13);
            this.baudrate_label.TabIndex = 28;
            this.baudrate_label.Text = "BaudRate";
            this.baudrate_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // COM_label
            // 
            this.COM_label.AutoSize = true;
            this.COM_label.Location = new System.Drawing.Point(15, 27);
            this.COM_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.COM_label.Name = "COM_label";
            this.COM_label.Size = new System.Drawing.Size(31, 13);
            this.COM_label.TabIndex = 24;
            this.COM_label.Text = "COM";
            // 
            // parity_combobox
            // 
            this.parity_combobox.FormattingEnabled = true;
            this.parity_combobox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.parity_combobox.Location = new System.Drawing.Point(80, 127);
            this.parity_combobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parity_combobox.Name = "parity_combobox";
            this.parity_combobox.Size = new System.Drawing.Size(69, 21);
            this.parity_combobox.TabIndex = 27;
            // 
            // stopbits_combobox
            // 
            this.stopbits_combobox.FormattingEnabled = true;
            this.stopbits_combobox.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.stopbits_combobox.Location = new System.Drawing.Point(80, 91);
            this.stopbits_combobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopbits_combobox.Name = "stopbits_combobox";
            this.stopbits_combobox.Size = new System.Drawing.Size(69, 21);
            this.stopbits_combobox.TabIndex = 26;
            // 
            // baudrate_combobox
            // 
            this.baudrate_combobox.FormattingEnabled = true;
            this.baudrate_combobox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.baudrate_combobox.Location = new System.Drawing.Point(80, 57);
            this.baudrate_combobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.baudrate_combobox.Name = "baudrate_combobox";
            this.baudrate_combobox.Size = new System.Drawing.Size(69, 21);
            this.baudrate_combobox.TabIndex = 25;
            // 
            // COM_combobox
            // 
            this.COM_combobox.FormattingEnabled = true;
            this.COM_combobox.Location = new System.Drawing.Point(80, 24);
            this.COM_combobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.COM_combobox.Name = "COM_combobox";
            this.COM_combobox.Size = new System.Drawing.Size(69, 21);
            this.COM_combobox.TabIndex = 24;
            this.COM_combobox.Click += new System.EventHandler(this.COM_combobox_Clicked);
            // 
            // Commands
            // 
            this.Commands.Controls.Add(this.label6);
            this.Commands.Controls.Add(this.label2);
            this.Commands.Controls.Add(this.mixed_TextBox);
            this.Commands.Controls.Add(this.tick_label);
            this.Commands.Controls.Add(this.DAC1_lab);
            this.Commands.Controls.Add(this.DAC1f_TextBox);
            this.Commands.Controls.Add(this.tick_TextBox);
            this.Commands.Controls.Add(this.auscSend_btn);
            this.Commands.Controls.Add(this.voltSend_btn);
            this.Commands.Controls.Add(this.phIncSend_btn);
            this.Commands.Controls.Add(this.label5);
            this.Commands.Controls.Add(this.label4);
            this.Commands.Controls.Add(this.label3);
            this.Commands.Controls.Add(this.DAC1_lab2);
            this.Commands.Controls.Add(this.label1);
            this.Commands.Controls.Add(this.volt_textBox);
            this.Commands.Controls.Add(this.phInc_textbox);
            this.Commands.Controls.Add(this.tick_btn);
            this.Commands.Controls.Add(this.sendValues_btn);
            this.Commands.Controls.Add(this.phInc_hScrollBar);
            this.Commands.Controls.Add(this.volt_hScrollBar);
            this.Commands.Controls.Add(this.ausc_hScrollBar);
            this.Commands.Location = new System.Drawing.Point(11, 206);
            this.Commands.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Commands.Name = "Commands";
            this.Commands.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Commands.Size = new System.Drawing.Size(354, 206);
            this.Commands.TabIndex = 40;
            this.Commands.TabStop = false;
            this.Commands.Text = "COM settings";
            // 
            // tick_label
            // 
            this.tick_label.AutoSize = true;
            this.tick_label.Location = new System.Drawing.Point(303, 171);
            this.tick_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tick_label.Name = "tick_label";
            this.tick_label.Size = new System.Drawing.Size(47, 13);
            this.tick_label.TabIndex = 54;
            this.tick_label.Text = "seconds";
            // 
            // DAC1_lab
            // 
            this.DAC1_lab.AutoSize = true;
            this.DAC1_lab.Location = new System.Drawing.Point(279, 112);
            this.DAC1_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DAC1_lab.Name = "DAC1_lab";
            this.DAC1_lab.Size = new System.Drawing.Size(29, 13);
            this.DAC1_lab.TabIndex = 53;
            this.DAC1_lab.Text = "MHz";
            // 
            // DAC1f_TextBox
            // 
            this.DAC1f_TextBox.Location = new System.Drawing.Point(230, 109);
            this.DAC1f_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DAC1f_TextBox.Name = "DAC1f_TextBox";
            this.DAC1f_TextBox.Size = new System.Drawing.Size(40, 20);
            this.DAC1f_TextBox.TabIndex = 52;
            this.DAC1f_TextBox.Text = "0";
            // 
            // tick_TextBox
            // 
            this.tick_TextBox.Location = new System.Drawing.Point(203, 168);
            this.tick_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tick_TextBox.Name = "tick_TextBox";
            this.tick_TextBox.Size = new System.Drawing.Size(99, 20);
            this.tick_TextBox.TabIndex = 51;
            this.tick_TextBox.Text = "0";
            // 
            // auscSend_btn
            // 
            this.auscSend_btn.Location = new System.Drawing.Point(114, 118);
            this.auscSend_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.auscSend_btn.Name = "auscSend_btn";
            this.auscSend_btn.Size = new System.Drawing.Size(36, 24);
            this.auscSend_btn.TabIndex = 50;
            this.auscSend_btn.Text = "->";
            this.auscSend_btn.UseVisualStyleBackColor = true;
            this.auscSend_btn.Click += new System.EventHandler(this.auscSend_btn_Click);
            // 
            // voltSend_btn
            // 
            this.voltSend_btn.Location = new System.Drawing.Point(314, 81);
            this.voltSend_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.voltSend_btn.Name = "voltSend_btn";
            this.voltSend_btn.Size = new System.Drawing.Size(36, 24);
            this.voltSend_btn.TabIndex = 49;
            this.voltSend_btn.Text = "->";
            this.voltSend_btn.UseVisualStyleBackColor = true;
            this.voltSend_btn.Click += new System.EventHandler(this.voltSend_btn_Click);
            // 
            // phIncSend_btn
            // 
            this.phIncSend_btn.Location = new System.Drawing.Point(314, 44);
            this.phIncSend_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phIncSend_btn.Name = "phIncSend_btn";
            this.phIncSend_btn.Size = new System.Drawing.Size(36, 24);
            this.phIncSend_btn.TabIndex = 48;
            this.phIncSend_btn.Text = "->";
            this.phIncSend_btn.UseVisualStyleBackColor = true;
            this.phIncSend_btn.Click += new System.EventHandler(this.phIncSend_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Audio source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "DAC1 output Voltage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "DAC0 phase Increment";
            // 
            // DAC1_lab2
            // 
            this.DAC1_lab2.AutoSize = true;
            this.DAC1_lab2.Location = new System.Drawing.Point(279, 89);
            this.DAC1_lab2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DAC1_lab2.Name = "DAC1_lab2";
            this.DAC1_lab2.Size = new System.Drawing.Size(22, 13);
            this.DAC1_lab2.TabIndex = 44;
            this.DAC1_lab2.Text = "mV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "MHz";
            // 
            // volt_textBox
            // 
            this.volt_textBox.Location = new System.Drawing.Point(230, 85);
            this.volt_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.volt_textBox.Name = "volt_textBox";
            this.volt_textBox.Size = new System.Drawing.Size(40, 20);
            this.volt_textBox.TabIndex = 41;
            this.volt_textBox.Text = "0";
            this.volt_textBox.TextChanged += new System.EventHandler(this.volt_textBox_TextChanged);
            // 
            // phInc_textbox
            // 
            this.phInc_textbox.Location = new System.Drawing.Point(230, 47);
            this.phInc_textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phInc_textbox.Name = "phInc_textbox";
            this.phInc_textbox.Size = new System.Drawing.Size(40, 20);
            this.phInc_textbox.TabIndex = 40;
            this.phInc_textbox.Text = "0";
            // 
            // tick_btn
            // 
            this.tick_btn.Location = new System.Drawing.Point(134, 165);
            this.tick_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tick_btn.Name = "tick_btn";
            this.tick_btn.Size = new System.Drawing.Size(64, 24);
            this.tick_btn.TabIndex = 17;
            this.tick_btn.Text = "Get Tick";
            this.tick_btn.UseVisualStyleBackColor = true;
            this.tick_btn.Click += new System.EventHandler(this.tick_btn_Click);
            // 
            // sendValues_btn
            // 
            this.sendValues_btn.Location = new System.Drawing.Point(14, 165);
            this.sendValues_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendValues_btn.Name = "sendValues_btn";
            this.sendValues_btn.Size = new System.Drawing.Size(116, 24);
            this.sendValues_btn.TabIndex = 16;
            this.sendValues_btn.Text = "Send values";
            this.sendValues_btn.UseVisualStyleBackColor = true;
            this.sendValues_btn.Click += new System.EventHandler(this.sendValues_btn_Click);
            // 
            // mixed_TextBox
            // 
            this.mixed_TextBox.Location = new System.Drawing.Point(230, 133);
            this.mixed_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.mixed_TextBox.Name = "mixed_TextBox";
            this.mixed_TextBox.Size = new System.Drawing.Size(40, 20);
            this.mixed_TextBox.TabIndex = 55;
            this.mixed_TextBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "mixed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "MHz";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.Commands);
            this.Controls.Add(this.COM_groupbox);
            this.Controls.Add(this.ComLog);
            this.Name = "MainForm";
            this.Text = "FM-TX Controller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.COM_groupbox.ResumeLayout(false);
            this.COM_groupbox.PerformLayout();
            this.Commands.ResumeLayout(false);
            this.Commands.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar phInc_hScrollBar;
        private System.Windows.Forms.HScrollBar volt_hScrollBar;
        private System.Windows.Forms.HScrollBar ausc_hScrollBar;
        private System.Windows.Forms.RichTextBox ComLog;
        private System.Windows.Forms.GroupBox COM_groupbox;
        private System.Windows.Forms.Label COMState_label;
        private System.Windows.Forms.Label COMstinfo_label;
        private System.Windows.Forms.Button COMConnectDisconnect_btn;
        private System.Windows.Forms.Label RxTimeoutUnit_label;
        private System.Windows.Forms.Label TxTimeoutUnit_label;
        private System.Windows.Forms.TextBox RxTimeout_textedit;
        private System.Windows.Forms.TextBox TxTimeout_textedit;
        private System.Windows.Forms.Label RxTimeout_label;
        private System.Windows.Forms.Label TxTimeout_label;
        private System.Windows.Forms.Label parity_label;
        private System.Windows.Forms.Label stopbits_label;
        private System.Windows.Forms.Label baudrate_label;
        private System.Windows.Forms.Label COM_label;
        private System.Windows.Forms.ComboBox parity_combobox;
        private System.Windows.Forms.ComboBox stopbits_combobox;
        private System.Windows.Forms.ComboBox baudrate_combobox;
        private System.Windows.Forms.ComboBox COM_combobox;
        private System.Windows.Forms.GroupBox Commands;
        private System.Windows.Forms.Button tick_btn;
        private System.Windows.Forms.Button sendValues_btn;
        private System.IO.Ports.SerialPort COM;
        private System.Windows.Forms.TextBox volt_textBox;
        private System.Windows.Forms.TextBox phInc_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DAC1_lab2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button auscSend_btn;
        private System.Windows.Forms.Button voltSend_btn;
        private System.Windows.Forms.Button phIncSend_btn;
        private System.Windows.Forms.TextBox tick_TextBox;
        private System.Windows.Forms.Label DAC1_lab;
        private System.Windows.Forms.TextBox DAC1f_TextBox;
        private System.Windows.Forms.Label tick_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mixed_TextBox;
    }
}

