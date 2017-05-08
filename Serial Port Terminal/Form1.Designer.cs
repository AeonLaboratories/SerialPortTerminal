namespace SerialPortTerminal
{
    partial class Form1
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
			this.ReceivedTextBox = new System.Windows.Forms.TextBox();
			this.CommandTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ClearButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ControllerConfiguration = new Utilities.SerialPortSettingsControl();
			this.CrcErrorLabel = new System.Windows.Forms.Label();
			this.NotReadyLabel = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.LoggingButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.ResponseCountTextBox = new System.Windows.Forms.TextBox();
			this.CommandCountTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.BytesReadTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.CrcOptionsGroupBox = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.InitialValueTextBox = new System.Windows.Forms.TextBox();
			this.PolynomialTextBox = new System.Windows.Forms.TextBox();
			this.MsByteFirstCheckBox = new System.Windows.Forms.CheckBox();
			this.ResidueTextBox = new System.Windows.Forms.TextBox();
			this.MsBitFirstCheckBox = new System.Windows.Forms.CheckBox();
			this.TermCharTextBox = new System.Windows.Forms.TextBox();
			this.OmitTermCharCheckBox = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.PostInvertCheckbox = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.TermCharLabel = new System.Windows.Forms.Label();
			this.txCrcTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.rxCrcTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.bytesCheckBox = new System.Windows.Forms.CheckBox();
			this.bytePaceTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.messagePaceTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.CrcOptionsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// ReceivedTextBox
			// 
			this.ReceivedTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ReceivedTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.ReceivedTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ReceivedTextBox.Location = new System.Drawing.Point(12, 279);
			this.ReceivedTextBox.Multiline = true;
			this.ReceivedTextBox.Name = "ReceivedTextBox";
			this.ReceivedTextBox.ReadOnly = true;
			this.ReceivedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.ReceivedTextBox.Size = new System.Drawing.Size(491, 229);
			this.ReceivedTextBox.TabIndex = 2;
			this.ReceivedTextBox.WordWrap = false;
			// 
			// CommandTextBox
			// 
			this.CommandTextBox.AcceptsReturn = true;
			this.CommandTextBox.Location = new System.Drawing.Point(12, 253);
			this.CommandTextBox.Name = "CommandTextBox";
			this.CommandTextBox.Size = new System.Drawing.Size(491, 20);
			this.CommandTextBox.TabIndex = 1;
			this.CommandTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 237);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Command:";
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(447, 514);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(56, 23);
			this.ClearButton.TabIndex = 5;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox1.Controls.Add(this.ControllerConfiguration);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(227, 196);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Controller Port Settings";
			// 
			// ControllerConfiguration
			// 
			this.ControllerConfiguration.AutoSize = true;
			this.ControllerConfiguration.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ControllerConfiguration.BaudRate = 115200;
			this.ControllerConfiguration.DataBits = 8;
			this.ControllerConfiguration.Handshake = System.IO.Ports.Handshake.None;
			this.ControllerConfiguration.Location = new System.Drawing.Point(6, 15);
			this.ControllerConfiguration.Name = "ControllerConfiguration";
			this.ControllerConfiguration.Parity = System.IO.Ports.Parity.None;
			this.ControllerConfiguration.PortName = "COM5";
			this.ControllerConfiguration.Size = new System.Drawing.Size(215, 162);
			this.ControllerConfiguration.StopBits = System.IO.Ports.StopBits.One;
			this.ControllerConfiguration.TabIndex = 6;
			// 
			// CrcErrorLabel
			// 
			this.CrcErrorLabel.AutoSize = true;
			this.CrcErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CrcErrorLabel.Location = new System.Drawing.Point(9, 519);
			this.CrcErrorLabel.Name = "CrcErrorLabel";
			this.CrcErrorLabel.Size = new System.Drawing.Size(67, 13);
			this.CrcErrorLabel.TabIndex = 8;
			this.CrcErrorLabel.Text = "CRC Error!";
			this.CrcErrorLabel.Visible = false;
			// 
			// NotReadyLabel
			// 
			this.NotReadyLabel.AutoSize = true;
			this.NotReadyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NotReadyLabel.Location = new System.Drawing.Point(82, 519);
			this.NotReadyLabel.Name = "NotReadyLabel";
			this.NotReadyLabel.Size = new System.Drawing.Size(67, 13);
			this.NotReadyLabel.TabIndex = 9;
			this.NotReadyLabel.Text = "Not Ready";
			this.NotReadyLabel.Visible = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
			this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(615, 24);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// FileMenuItem
			// 
			this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpenMenuItem,
            this.exitMenuItem});
			this.FileMenuItem.Name = "FileMenuItem";
			this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
			this.FileMenuItem.Text = "&File";
			// 
			// fileOpenMenuItem
			// 
			this.fileOpenMenuItem.Name = "fileOpenMenuItem";
			this.fileOpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.fileOpenMenuItem.Size = new System.Drawing.Size(155, 22);
			this.fileOpenMenuItem.Text = "&Open...";
			this.fileOpenMenuItem.Click += new System.EventHandler(this.fileOpenMenuItem_Click);
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitMenuItem.Size = new System.Drawing.Size(155, 22);
			this.exitMenuItem.Text = "E&xit";
			this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "txt";
			this.openFileDialog1.Filter = "Text files|*.txt;*.csv";
			this.openFileDialog1.Title = "Select file to graph";
			// 
			// LoggingButton
			// 
			this.LoggingButton.Location = new System.Drawing.Point(359, 514);
			this.LoggingButton.Name = "LoggingButton";
			this.LoggingButton.Size = new System.Drawing.Size(82, 23);
			this.LoggingButton.TabIndex = 11;
			this.LoggingButton.Text = "Start Logging";
			this.LoggingButton.UseVisualStyleBackColor = true;
			this.LoggingButton.Click += new System.EventHandler(this.LoggingButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(509, 433);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Responses";
			// 
			// ResponseCountTextBox
			// 
			this.ResponseCountTextBox.AcceptsReturn = true;
			this.ResponseCountTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ResponseCountTextBox.Location = new System.Drawing.Point(509, 449);
			this.ResponseCountTextBox.Name = "ResponseCountTextBox";
			this.ResponseCountTextBox.ReadOnly = true;
			this.ResponseCountTextBox.Size = new System.Drawing.Size(92, 20);
			this.ResponseCountTextBox.TabIndex = 1;
			this.ResponseCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
			// 
			// CommandCountTextBox
			// 
			this.CommandCountTextBox.AcceptsReturn = true;
			this.CommandCountTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.CommandCountTextBox.Location = new System.Drawing.Point(509, 410);
			this.CommandCountTextBox.Name = "CommandCountTextBox";
			this.CommandCountTextBox.ReadOnly = true;
			this.CommandCountTextBox.Size = new System.Drawing.Size(92, 20);
			this.CommandCountTextBox.TabIndex = 1;
			this.CommandCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(509, 394);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Commands";
			// 
			// BytesReadTextBox
			// 
			this.BytesReadTextBox.AcceptsReturn = true;
			this.BytesReadTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BytesReadTextBox.Location = new System.Drawing.Point(509, 488);
			this.BytesReadTextBox.Name = "BytesReadTextBox";
			this.BytesReadTextBox.ReadOnly = true;
			this.BytesReadTextBox.Size = new System.Drawing.Size(92, 20);
			this.BytesReadTextBox.TabIndex = 1;
			this.BytesReadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressHandler);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(509, 472);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "BytesRead";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// CrcOptionsGroupBox
			// 
			this.CrcOptionsGroupBox.Controls.Add(this.label6);
			this.CrcOptionsGroupBox.Controls.Add(this.InitialValueTextBox);
			this.CrcOptionsGroupBox.Controls.Add(this.PolynomialTextBox);
			this.CrcOptionsGroupBox.Controls.Add(this.MsByteFirstCheckBox);
			this.CrcOptionsGroupBox.Controls.Add(this.ResidueTextBox);
			this.CrcOptionsGroupBox.Controls.Add(this.MsBitFirstCheckBox);
			this.CrcOptionsGroupBox.Controls.Add(this.TermCharTextBox);
			this.CrcOptionsGroupBox.Controls.Add(this.OmitTermCharCheckBox);
			this.CrcOptionsGroupBox.Controls.Add(this.label7);
			this.CrcOptionsGroupBox.Controls.Add(this.PostInvertCheckbox);
			this.CrcOptionsGroupBox.Controls.Add(this.label8);
			this.CrcOptionsGroupBox.Controls.Add(this.TermCharLabel);
			this.CrcOptionsGroupBox.Location = new System.Drawing.Point(245, 27);
			this.CrcOptionsGroupBox.Name = "CrcOptionsGroupBox";
			this.CrcOptionsGroupBox.Size = new System.Drawing.Size(341, 98);
			this.CrcOptionsGroupBox.TabIndex = 13;
			this.CrcOptionsGroupBox.TabStop = false;
			this.CrcOptionsGroupBox.Text = "CRC Options";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Initial Value";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// InitialValueTextBox
			// 
			this.InitialValueTextBox.Location = new System.Drawing.Point(73, 22);
			this.InitialValueTextBox.Name = "InitialValueTextBox";
			this.InitialValueTextBox.Size = new System.Drawing.Size(44, 20);
			this.InitialValueTextBox.TabIndex = 2;
			this.InitialValueTextBox.Text = "FFFF";
			this.InitialValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.InitialValueTextBox.Leave += new System.EventHandler(this.InitialValueTextBox_Leave);
			// 
			// PolynomialTextBox
			// 
			this.PolynomialTextBox.Location = new System.Drawing.Point(186, 22);
			this.PolynomialTextBox.Name = "PolynomialTextBox";
			this.PolynomialTextBox.Size = new System.Drawing.Size(44, 20);
			this.PolynomialTextBox.TabIndex = 2;
			this.PolynomialTextBox.Text = "BAAD";
			this.PolynomialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.PolynomialTextBox.Leave += new System.EventHandler(this.PolynomialTextBox_Leave);
			// 
			// MsByteFirstCheckBox
			// 
			this.MsByteFirstCheckBox.AutoSize = true;
			this.MsByteFirstCheckBox.Location = new System.Drawing.Point(79, 48);
			this.MsByteFirstCheckBox.Name = "MsByteFirstCheckBox";
			this.MsByteFirstCheckBox.Size = new System.Drawing.Size(68, 17);
			this.MsByteFirstCheckBox.TabIndex = 10;
			this.MsByteFirstCheckBox.Text = "MSB-first";
			this.MsByteFirstCheckBox.UseVisualStyleBackColor = true;
			// 
			// ResidueTextBox
			// 
			this.ResidueTextBox.Location = new System.Drawing.Point(288, 22);
			this.ResidueTextBox.Name = "ResidueTextBox";
			this.ResidueTextBox.Size = new System.Drawing.Size(44, 20);
			this.ResidueTextBox.TabIndex = 2;
			this.ResidueTextBox.Text = "0820";
			this.ResidueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ResidueTextBox.Leave += new System.EventHandler(this.ResidueTextBox_Leave);
			// 
			// MsBitFirstCheckBox
			// 
			this.MsBitFirstCheckBox.AutoSize = true;
			this.MsBitFirstCheckBox.Location = new System.Drawing.Point(9, 48);
			this.MsBitFirstCheckBox.Name = "MsBitFirstCheckBox";
			this.MsBitFirstCheckBox.Size = new System.Drawing.Size(64, 17);
			this.MsBitFirstCheckBox.TabIndex = 10;
			this.MsBitFirstCheckBox.Text = "msb-first";
			this.MsBitFirstCheckBox.UseVisualStyleBackColor = true;
			// 
			// TermCharTextBox
			// 
			this.TermCharTextBox.Location = new System.Drawing.Point(186, 68);
			this.TermCharTextBox.Name = "TermCharTextBox";
			this.TermCharTextBox.Size = new System.Drawing.Size(34, 20);
			this.TermCharTextBox.TabIndex = 2;
			this.TermCharTextBox.Text = "03";
			this.TermCharTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TermCharTextBox.Leave += new System.EventHandler(this.TermCharTextBox_Leave);
			// 
			// OmitTermCharCheckBox
			// 
			this.OmitTermCharCheckBox.AutoSize = true;
			this.OmitTermCharCheckBox.Location = new System.Drawing.Point(9, 71);
			this.OmitTermCharCheckBox.Name = "OmitTermCharCheckBox";
			this.OmitTermCharCheckBox.Size = new System.Drawing.Size(96, 17);
			this.OmitTermCharCheckBox.TabIndex = 10;
			this.OmitTermCharCheckBox.Text = "Omit TermChar";
			this.OmitTermCharCheckBox.UseVisualStyleBackColor = true;
			this.OmitTermCharCheckBox.CheckedChanged += new System.EventHandler(this.OmitTermCharCheckBox_CheckedChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(123, 25);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Polynomial";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// PostInvertCheckbox
			// 
			this.PostInvertCheckbox.AutoSize = true;
			this.PostInvertCheckbox.Checked = true;
			this.PostInvertCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.PostInvertCheckbox.Location = new System.Drawing.Point(153, 48);
			this.PostInvertCheckbox.Name = "PostInvertCheckbox";
			this.PostInvertCheckbox.Size = new System.Drawing.Size(76, 17);
			this.PostInvertCheckbox.TabIndex = 10;
			this.PostInvertCheckbox.Text = "Post-invert";
			this.PostInvertCheckbox.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(236, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Residue";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TermCharLabel
			// 
			this.TermCharLabel.AutoSize = true;
			this.TermCharLabel.Location = new System.Drawing.Point(127, 71);
			this.TermCharLabel.Name = "TermCharLabel";
			this.TermCharLabel.Size = new System.Drawing.Size(53, 13);
			this.TermCharLabel.TabIndex = 0;
			this.TermCharLabel.Text = "TermChar";
			this.TermCharLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txCrcTextBox
			// 
			this.txCrcTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txCrcTextBox.Location = new System.Drawing.Point(552, 253);
			this.txCrcTextBox.Name = "txCrcTextBox";
			this.txCrcTextBox.ReadOnly = true;
			this.txCrcTextBox.Size = new System.Drawing.Size(44, 20);
			this.txCrcTextBox.TabIndex = 2;
			this.txCrcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(509, 256);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "txCRC";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rxCrcTextBox
			// 
			this.rxCrcTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.rxCrcTextBox.Location = new System.Drawing.Point(552, 280);
			this.rxCrcTextBox.Name = "rxCrcTextBox";
			this.rxCrcTextBox.ReadOnly = true;
			this.rxCrcTextBox.Size = new System.Drawing.Size(44, 20);
			this.rxCrcTextBox.TabIndex = 2;
			this.rxCrcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(509, 283);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(37, 13);
			this.label9.TabIndex = 5;
			this.label9.Text = "rxCRC";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// bytesCheckBox
			// 
			this.bytesCheckBox.AutoSize = true;
			this.bytesCheckBox.Location = new System.Drawing.Point(512, 306);
			this.bytesCheckBox.Name = "bytesCheckBox";
			this.bytesCheckBox.Size = new System.Drawing.Size(79, 17);
			this.bytesCheckBox.TabIndex = 10;
			this.bytesCheckBox.Text = "show bytes";
			this.bytesCheckBox.UseVisualStyleBackColor = true;
			this.bytesCheckBox.CheckedChanged += new System.EventHandler(this.bytesCheckBox_CheckedChanged);
			// 
			// bytePaceTextBox
			// 
			this.bytePaceTextBox.Location = new System.Drawing.Point(327, 131);
			this.bytePaceTextBox.Name = "bytePaceTextBox";
			this.bytePaceTextBox.Size = new System.Drawing.Size(44, 20);
			this.bytePaceTextBox.TabIndex = 2;
			this.bytePaceTextBox.Text = "-1";
			this.bytePaceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.bytePaceTextBox.Leave += new System.EventHandler(this.bytePaceTextBox_Leave);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(267, 134);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(54, 13);
			this.label10.TabIndex = 0;
			this.label10.Text = "byte pace";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// messagePaceTextBox
			// 
			this.messagePaceTextBox.Location = new System.Drawing.Point(327, 157);
			this.messagePaceTextBox.Name = "messagePaceTextBox";
			this.messagePaceTextBox.Size = new System.Drawing.Size(44, 20);
			this.messagePaceTextBox.TabIndex = 2;
			this.messagePaceTextBox.Text = "0";
			this.messagePaceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.messagePaceTextBox.Leave += new System.EventHandler(this.messagePaceTextBox_Leave);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(245, 160);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(76, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "message pace";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(377, 134);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(89, 13);
			this.label12.TabIndex = 0;
			this.label12.Text = "(ms; -1 to disable)";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(377, 160);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(26, 13);
			this.label13.TabIndex = 0;
			this.label13.Text = "(ms)";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 552);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.messagePaceTextBox);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.bytePaceTextBox);
			this.Controls.Add(this.CrcOptionsGroupBox);
			this.Controls.Add(this.LoggingButton);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.NotReadyLabel);
			this.Controls.Add(this.CrcErrorLabel);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.bytesCheckBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.BytesReadTextBox);
			this.Controls.Add(this.rxCrcTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txCrcTextBox);
			this.Controls.Add(this.CommandCountTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ResponseCountTextBox);
			this.Controls.Add(this.CommandTextBox);
			this.Controls.Add(this.ReceivedTextBox);
			this.Name = "Form1";
			this.Text = "Serial Port Terminal";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingHandler);
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.CrcOptionsGroupBox.ResumeLayout(false);
			this.CrcOptionsGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReceivedTextBox;
        private System.Windows.Forms.TextBox CommandTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private Utilities.SerialPortSettingsControl ControllerConfiguration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CrcErrorLabel;
        private System.Windows.Forms.Label NotReadyLabel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileOpenMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button LoggingButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ResponseCountTextBox;
        private System.Windows.Forms.TextBox CommandCountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BytesReadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox CrcOptionsGroupBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox InitialValueTextBox;
		private System.Windows.Forms.TextBox PolynomialTextBox;
		private System.Windows.Forms.CheckBox MsByteFirstCheckBox;
		private System.Windows.Forms.TextBox ResidueTextBox;
		private System.Windows.Forms.CheckBox MsBitFirstCheckBox;
		private System.Windows.Forms.TextBox TermCharTextBox;
		private System.Windows.Forms.CheckBox OmitTermCharCheckBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox PostInvertCheckbox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label TermCharLabel;
		private System.Windows.Forms.TextBox txCrcTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox rxCrcTextBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox bytesCheckBox;
		private System.Windows.Forms.TextBox bytePaceTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox messagePaceTextBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
    }
}

