namespace SerialCommunicate
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Setting = new System.Windows.Forms.GroupBox();
            this.stopBit = new System.Windows.Forms.ComboBox();
            this.stopBitName = new System.Windows.Forms.Label();
            this.dataBit = new System.Windows.Forms.ComboBox();
            this.dataBitName = new System.Windows.Forms.Label();
            this.verificationBit = new System.Windows.Forms.ComboBox();
            this.verificationBitName = new System.Windows.Forms.Label();
            this.ClosePort = new System.Windows.Forms.Button();
            this.OpenPort = new System.Windows.Forms.Button();
            this.baud = new System.Windows.Forms.ComboBox();
            this.baudName = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.ComboBox();
            this.portName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RXnum = new System.Windows.Forms.RadioButton();
            this.RXchar = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXchar = new System.Windows.Forms.RadioButton();
            this.TXnum = new System.Windows.Forms.RadioButton();
            this.RXmode = new System.Windows.Forms.Label();
            this.TXmode = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.GroupBox();
            this.auto = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TXclr = new System.Windows.Forms.Button();
            this.RXclr = new System.Windows.Forms.Button();
            this.Statu = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clearCount = new System.Windows.Forms.Button();
            this.RxByteCount = new System.Windows.Forms.TextBox();
            this.TxByteCount = new System.Windows.Forms.TextBox();
            this.RxByteCountName = new System.Windows.Forms.Label();
            this.TxByteCountName = new System.Windows.Forms.Label();
            this.portStatu = new System.Windows.Forms.TextBox();
            this.portStatuName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Setting.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Data.SuspendLayout();
            this.Statu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.stopBit);
            this.Setting.Controls.Add(this.stopBitName);
            this.Setting.Controls.Add(this.dataBit);
            this.Setting.Controls.Add(this.dataBitName);
            this.Setting.Controls.Add(this.verificationBit);
            this.Setting.Controls.Add(this.verificationBitName);
            this.Setting.Controls.Add(this.ClosePort);
            this.Setting.Controls.Add(this.OpenPort);
            this.Setting.Controls.Add(this.baud);
            this.Setting.Controls.Add(this.baudName);
            this.Setting.Controls.Add(this.port);
            this.Setting.Controls.Add(this.portName);
            this.Setting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Setting.Location = new System.Drawing.Point(16, 6);
            this.Setting.Margin = new System.Windows.Forms.Padding(4);
            this.Setting.Name = "Setting";
            this.Setting.Padding = new System.Windows.Forms.Padding(4);
            this.Setting.Size = new System.Drawing.Size(244, 272);
            this.Setting.TabIndex = 0;
            this.Setting.TabStop = false;
            this.Setting.Text = "设置";
            // 
            // stopBit
            // 
            this.stopBit.AutoCompleteCustomSource.AddRange(new string[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.stopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBit.FormattingEnabled = true;
            this.stopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopBit.Location = new System.Drawing.Point(88, 176);
            this.stopBit.Margin = new System.Windows.Forms.Padding(4);
            this.stopBit.Name = "stopBit";
            this.stopBit.Size = new System.Drawing.Size(142, 28);
            this.stopBit.TabIndex = 17;
            this.stopBit.SelectedIndexChanged += new System.EventHandler(this.stopBit_SelectedIndexChanged);
            // 
            // stopBitName
            // 
            this.stopBitName.AutoSize = true;
            this.stopBitName.Location = new System.Drawing.Point(9, 179);
            this.stopBitName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stopBitName.Name = "stopBitName";
            this.stopBitName.Size = new System.Drawing.Size(54, 20);
            this.stopBitName.TabIndex = 16;
            this.stopBitName.Text = "停止位";
            // 
            // dataBit
            // 
            this.dataBit.AutoCompleteCustomSource.AddRange(new string[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.dataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataBit.FormattingEnabled = true;
            this.dataBit.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.dataBit.Location = new System.Drawing.Point(88, 100);
            this.dataBit.Margin = new System.Windows.Forms.Padding(4);
            this.dataBit.Name = "dataBit";
            this.dataBit.Size = new System.Drawing.Size(142, 28);
            this.dataBit.TabIndex = 15;
            this.dataBit.SelectedIndexChanged += new System.EventHandler(this.dataBit_SelectedIndexChanged);
            // 
            // dataBitName
            // 
            this.dataBitName.AutoSize = true;
            this.dataBitName.Location = new System.Drawing.Point(9, 103);
            this.dataBitName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dataBitName.Name = "dataBitName";
            this.dataBitName.Size = new System.Drawing.Size(54, 20);
            this.dataBitName.TabIndex = 14;
            this.dataBitName.Text = "数据位";
            // 
            // verificationBit
            // 
            this.verificationBit.AutoCompleteCustomSource.AddRange(new string[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.verificationBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.verificationBit.FormattingEnabled = true;
            this.verificationBit.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.verificationBit.Location = new System.Drawing.Point(88, 136);
            this.verificationBit.Margin = new System.Windows.Forms.Padding(4);
            this.verificationBit.Name = "verificationBit";
            this.verificationBit.Size = new System.Drawing.Size(142, 28);
            this.verificationBit.TabIndex = 13;
            this.verificationBit.SelectedIndexChanged += new System.EventHandler(this.verificationBit_SelectedIndexChanged);
            // 
            // verificationBitName
            // 
            this.verificationBitName.AutoSize = true;
            this.verificationBitName.Location = new System.Drawing.Point(9, 144);
            this.verificationBitName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.verificationBitName.Name = "verificationBitName";
            this.verificationBitName.Size = new System.Drawing.Size(54, 20);
            this.verificationBitName.TabIndex = 12;
            this.verificationBitName.Text = "校验位";
            // 
            // ClosePort
            // 
            this.ClosePort.Enabled = false;
            this.ClosePort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClosePort.Location = new System.Drawing.Point(131, 216);
            this.ClosePort.Margin = new System.Windows.Forms.Padding(4);
            this.ClosePort.Name = "ClosePort";
            this.ClosePort.Size = new System.Drawing.Size(99, 29);
            this.ClosePort.TabIndex = 11;
            this.ClosePort.Text = "关闭端口";
            this.ClosePort.UseVisualStyleBackColor = true;
            this.ClosePort.Click += new System.EventHandler(this.button2_Click);
            // 
            // OpenPort
            // 
            this.OpenPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenPort.Location = new System.Drawing.Point(13, 216);
            this.OpenPort.Margin = new System.Windows.Forms.Padding(4);
            this.OpenPort.Name = "OpenPort";
            this.OpenPort.Size = new System.Drawing.Size(99, 29);
            this.OpenPort.TabIndex = 4;
            this.OpenPort.Text = "打开端口";
            this.OpenPort.UseVisualStyleBackColor = true;
            this.OpenPort.Click += new System.EventHandler(this.button1_Click);
            // 
            // baud
            // 
            this.baud.AutoCompleteCustomSource.AddRange(new string[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baud.FormattingEnabled = true;
            this.baud.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.baud.Location = new System.Drawing.Point(88, 64);
            this.baud.Margin = new System.Windows.Forms.Padding(4);
            this.baud.Name = "baud";
            this.baud.Size = new System.Drawing.Size(142, 28);
            this.baud.TabIndex = 3;
            // 
            // baudName
            // 
            this.baudName.AutoSize = true;
            this.baudName.Location = new System.Drawing.Point(9, 62);
            this.baudName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baudName.Name = "baudName";
            this.baudName.Size = new System.Drawing.Size(54, 20);
            this.baudName.TabIndex = 2;
            this.baudName.Text = "波特率";
            // 
            // port
            // 
            this.port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.port.FormattingEnabled = true;
            this.port.Location = new System.Drawing.Point(88, 25);
            this.port.Margin = new System.Windows.Forms.Padding(4);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(142, 28);
            this.port.TabIndex = 1;
            // 
            // portName
            // 
            this.portName.AutoSize = true;
            this.portName.Location = new System.Drawing.Point(24, 25);
            this.portName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portName.Name = "portName";
            this.portName.Size = new System.Drawing.Size(39, 20);
            this.portName.TabIndex = 0;
            this.portName.Text = "端口";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RXnum);
            this.panel2.Controls.Add(this.RXchar);
            this.panel2.Location = new System.Drawing.Point(126, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 35);
            this.panel2.TabIndex = 10;
            // 
            // RXnum
            // 
            this.RXnum.AutoSize = true;
            this.RXnum.Checked = true;
            this.RXnum.Location = new System.Drawing.Point(4, 4);
            this.RXnum.Margin = new System.Windows.Forms.Padding(4);
            this.RXnum.Name = "RXnum";
            this.RXnum.Size = new System.Drawing.Size(60, 24);
            this.RXnum.TabIndex = 9;
            this.RXnum.TabStop = true;
            this.RXnum.Text = "数值";
            this.RXnum.UseVisualStyleBackColor = true;
            // 
            // RXchar
            // 
            this.RXchar.AutoSize = true;
            this.RXchar.Location = new System.Drawing.Point(91, 4);
            this.RXchar.Margin = new System.Windows.Forms.Padding(4);
            this.RXchar.Name = "RXchar";
            this.RXchar.Size = new System.Drawing.Size(60, 24);
            this.RXchar.TabIndex = 8;
            this.RXchar.Text = "字符";
            this.RXchar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TXchar);
            this.panel1.Controls.Add(this.TXnum);
            this.panel1.Location = new System.Drawing.Point(112, 281);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 34);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TXchar
            // 
            this.TXchar.AutoSize = true;
            this.TXchar.Location = new System.Drawing.Point(93, 4);
            this.TXchar.Margin = new System.Windows.Forms.Padding(4);
            this.TXchar.Name = "TXchar";
            this.TXchar.Size = new System.Drawing.Size(60, 24);
            this.TXchar.TabIndex = 9;
            this.TXchar.Text = "字符";
            this.TXchar.UseVisualStyleBackColor = true;
            // 
            // TXnum
            // 
            this.TXnum.AutoSize = true;
            this.TXnum.Checked = true;
            this.TXnum.Location = new System.Drawing.Point(8, 4);
            this.TXnum.Margin = new System.Windows.Forms.Padding(4);
            this.TXnum.Name = "TXnum";
            this.TXnum.Size = new System.Drawing.Size(60, 24);
            this.TXnum.TabIndex = 8;
            this.TXnum.TabStop = true;
            this.TXnum.Text = "数值";
            this.TXnum.UseVisualStyleBackColor = true;
            // 
            // RXmode
            // 
            this.RXmode.AutoSize = true;
            this.RXmode.Location = new System.Drawing.Point(49, 28);
            this.RXmode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RXmode.Name = "RXmode";
            this.RXmode.Size = new System.Drawing.Size(69, 20);
            this.RXmode.TabIndex = 8;
            this.RXmode.Text = "接收模式";
            // 
            // TXmode
            // 
            this.TXmode.AutoSize = true;
            this.TXmode.Location = new System.Drawing.Point(35, 287);
            this.TXmode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TXmode.Name = "TXmode";
            this.TXmode.Size = new System.Drawing.Size(69, 20);
            this.TXmode.TabIndex = 5;
            this.TXmode.Text = "发送模式";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(9, 64);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(325, 157);
            this.textBox1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(225, 468);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "发送";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 333);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(325, 73);
            this.textBox2.TabIndex = 5;
            // 
            // Data
            // 
            this.Data.Controls.Add(this.auto);
            this.Data.Controls.Add(this.textBox4);
            this.Data.Controls.Add(this.textBox3);
            this.Data.Controls.Add(this.TXclr);
            this.Data.Controls.Add(this.RXclr);
            this.Data.Controls.Add(this.textBox1);
            this.Data.Controls.Add(this.button3);
            this.Data.Controls.Add(this.textBox2);
            this.Data.Controls.Add(this.RXmode);
            this.Data.Controls.Add(this.panel2);
            this.Data.Controls.Add(this.panel1);
            this.Data.Controls.Add(this.TXmode);
            this.Data.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Data.Location = new System.Drawing.Point(280, 6);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(341, 517);
            this.Data.TabIndex = 6;
            this.Data.TabStop = false;
            this.Data.Text = "数据";
            // 
            // auto
            // 
            this.auto.AutoSize = true;
            this.auto.Location = new System.Drawing.Point(9, 433);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(91, 24);
            this.auto.TabIndex = 17;
            this.auto.Text = "自动发送";
            this.auto.UseVisualStyleBackColor = true;
            this.auto.CheckedChanged += new System.EventHandler(this.auto_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(240, 431);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(52, 20);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "ms";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 424);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 27);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "1000";
            // 
            // TXclr
            // 
            this.TXclr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TXclr.Location = new System.Drawing.Point(7, 478);
            this.TXclr.Margin = new System.Windows.Forms.Padding(4);
            this.TXclr.Name = "TXclr";
            this.TXclr.Size = new System.Drawing.Size(85, 32);
            this.TXclr.TabIndex = 12;
            this.TXclr.Text = "清除";
            this.TXclr.UseVisualStyleBackColor = true;
            this.TXclr.Click += new System.EventHandler(this.TXclr_Click);
            // 
            // RXclr
            // 
            this.RXclr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RXclr.Location = new System.Drawing.Point(7, 229);
            this.RXclr.Margin = new System.Windows.Forms.Padding(4);
            this.RXclr.Name = "RXclr";
            this.RXclr.Size = new System.Drawing.Size(85, 32);
            this.RXclr.TabIndex = 11;
            this.RXclr.Text = "清除";
            this.RXclr.UseVisualStyleBackColor = true;
            this.RXclr.Click += new System.EventHandler(this.button4_Click);
            // 
            // Statu
            // 
            this.Statu.Controls.Add(this.button2);
            this.Statu.Controls.Add(this.button1);
            this.Statu.Controls.Add(this.clearCount);
            this.Statu.Controls.Add(this.RxByteCount);
            this.Statu.Controls.Add(this.TxByteCount);
            this.Statu.Controls.Add(this.RxByteCountName);
            this.Statu.Controls.Add(this.TxByteCountName);
            this.Statu.Controls.Add(this.portStatu);
            this.Statu.Controls.Add(this.portStatuName);
            this.Statu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Statu.Location = new System.Drawing.Point(16, 296);
            this.Statu.Margin = new System.Windows.Forms.Padding(4);
            this.Statu.Name = "Statu";
            this.Statu.Padding = new System.Windows.Forms.Padding(4);
            this.Statu.Size = new System.Drawing.Size(244, 226);
            this.Statu.TabIndex = 7;
            this.Statu.TabStop = false;
            this.Statu.Text = "状态";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "关于";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // clearCount
            // 
            this.clearCount.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearCount.Location = new System.Drawing.Point(13, 131);
            this.clearCount.Name = "clearCount";
            this.clearCount.Size = new System.Drawing.Size(84, 32);
            this.clearCount.TabIndex = 8;
            this.clearCount.Text = "清除计数";
            this.clearCount.UseVisualStyleBackColor = true;
            this.clearCount.Click += new System.EventHandler(this.clearCount_Click);
            // 
            // RxByteCount
            // 
            this.RxByteCount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.RxByteCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RxByteCount.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RxByteCount.Location = new System.Drawing.Point(104, 96);
            this.RxByteCount.Name = "RxByteCount";
            this.RxByteCount.ReadOnly = true;
            this.RxByteCount.Size = new System.Drawing.Size(100, 20);
            this.RxByteCount.TabIndex = 15;
            this.RxByteCount.Text = "0";
            // 
            // TxByteCount
            // 
            this.TxByteCount.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxByteCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxByteCount.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxByteCount.Location = new System.Drawing.Point(104, 63);
            this.TxByteCount.Name = "TxByteCount";
            this.TxByteCount.ReadOnly = true;
            this.TxByteCount.Size = new System.Drawing.Size(100, 20);
            this.TxByteCount.TabIndex = 14;
            this.TxByteCount.Text = "0";
            // 
            // RxByteCountName
            // 
            this.RxByteCountName.AutoSize = true;
            this.RxByteCountName.Location = new System.Drawing.Point(24, 96);
            this.RxByteCountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RxByteCountName.Name = "RxByteCountName";
            this.RxByteCountName.Size = new System.Drawing.Size(73, 20);
            this.RxByteCountName.TabIndex = 13;
            this.RxByteCountName.Text = "接收字节:";
            // 
            // TxByteCountName
            // 
            this.TxByteCountName.AutoSize = true;
            this.TxByteCountName.Location = new System.Drawing.Point(24, 63);
            this.TxByteCountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TxByteCountName.Name = "TxByteCountName";
            this.TxByteCountName.Size = new System.Drawing.Size(73, 20);
            this.TxByteCountName.TabIndex = 12;
            this.TxByteCountName.Text = "发送字节:";
            // 
            // portStatu
            // 
            this.portStatu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.portStatu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portStatu.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.portStatu.Location = new System.Drawing.Point(104, 33);
            this.portStatu.Name = "portStatu";
            this.portStatu.ReadOnly = true;
            this.portStatu.Size = new System.Drawing.Size(100, 20);
            this.portStatu.TabIndex = 11;
            this.portStatu.Text = "Closed";
            // 
            // portStatuName
            // 
            this.portStatuName.AutoSize = true;
            this.portStatuName.Location = new System.Drawing.Point(24, 33);
            this.portStatuName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portStatuName.Name = "portStatuName";
            this.portStatuName.Size = new System.Drawing.Size(73, 20);
            this.portStatuName.TabIndex = 1;
            this.portStatuName.Text = "端口状态:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(666, 535);
            this.Controls.Add(this.Statu);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Setting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Serial Communicate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Data.ResumeLayout(false);
            this.Data.PerformLayout();
            this.Statu.ResumeLayout(false);
            this.Statu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox Setting;
        private System.Windows.Forms.Label portName;
        private System.Windows.Forms.Button OpenPort;
        private System.Windows.Forms.ComboBox baud;
        private System.Windows.Forms.Label baudName;
        public System.Windows.Forms.ComboBox port;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label RXmode;
        private System.Windows.Forms.Label TXmode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton TXchar;
        private System.Windows.Forms.RadioButton TXnum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RXnum;
        private System.Windows.Forms.RadioButton RXchar;
        private System.Windows.Forms.Button ClosePort;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox Data;
        private System.Windows.Forms.ComboBox stopBit;
        private System.Windows.Forms.Label stopBitName;
        private System.Windows.Forms.ComboBox dataBit;
        private System.Windows.Forms.Label dataBitName;
        private System.Windows.Forms.ComboBox verificationBit;
        private System.Windows.Forms.Label verificationBitName;
        private System.Windows.Forms.GroupBox Statu;
        private System.Windows.Forms.TextBox portStatu;
        private System.Windows.Forms.Label portStatuName;
        private System.Windows.Forms.TextBox RxByteCount;
        private System.Windows.Forms.TextBox TxByteCount;
        private System.Windows.Forms.Label RxByteCountName;
        private System.Windows.Forms.Label TxByteCountName;
        private System.Windows.Forms.Button clearCount;
        private System.Windows.Forms.Button RXclr;
        private System.Windows.Forms.Button TXclr;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox auto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

