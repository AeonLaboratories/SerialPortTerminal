namespace CRC_tester
{
    partial class CrcForm
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
            this.msgTextBox = new System.Windows.Forms.TextBox();
            this.msgCrcTextBox = new System.Windows.Forms.TextBox();
            this.txBytesTextBox = new System.Windows.Forms.TextBox();
            this.rxCrcTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rxCrcCheckBox = new System.Windows.Forms.CheckBox();
            this.unescapeCheckBox = new System.Windows.Forms.CheckBox();
            this.workingCrcTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InitalValueTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PolynomialTextBox = new System.Windows.Forms.TextBox();
            this.ResidueTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TermCharTextBox = new System.Windows.Forms.TextBox();
            this.TermCharLabel = new System.Windows.Forms.Label();
            this.PostInvertCheckbox = new System.Windows.Forms.CheckBox();
            this.MsBitFirstCheckBox = new System.Windows.Forms.CheckBox();
            this.MsByteFirstCheckBox = new System.Windows.Forms.CheckBox();
            this.OmitTermCharCheckBox = new System.Windows.Forms.CheckBox();
            this.CrcOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.CrcOptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgTextBox
            // 
            this.msgTextBox.Location = new System.Drawing.Point(12, 150);
            this.msgTextBox.Name = "msgTextBox";
            this.msgTextBox.Size = new System.Drawing.Size(376, 20);
            this.msgTextBox.TabIndex = 0;
            this.msgTextBox.TextChanged += new System.EventHandler(this.msg_TextChanged);
            // 
            // msgCrcTextBox
            // 
            this.msgCrcTextBox.Location = new System.Drawing.Point(45, 176);
            this.msgCrcTextBox.Name = "msgCrcTextBox";
            this.msgCrcTextBox.Size = new System.Drawing.Size(34, 20);
            this.msgCrcTextBox.TabIndex = 2;
            this.msgCrcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txBytesTextBox
            // 
            this.txBytesTextBox.Location = new System.Drawing.Point(12, 227);
            this.txBytesTextBox.Name = "txBytesTextBox";
            this.txBytesTextBox.Size = new System.Drawing.Size(376, 20);
            this.txBytesTextBox.TabIndex = 3;
            // 
            // rxCrcTextBox
            // 
            this.rxCrcTextBox.Location = new System.Drawing.Point(49, 253);
            this.rxCrcTextBox.Name = "rxCrcTextBox";
            this.rxCrcTextBox.Size = new System.Drawing.Size(34, 20);
            this.rxCrcTextBox.TabIndex = 4;
            this.rxCrcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CRC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transmit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Verify";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rxCrcCheckBox
            // 
            this.rxCrcCheckBox.AutoSize = true;
            this.rxCrcCheckBox.Location = new System.Drawing.Point(89, 255);
            this.rxCrcCheckBox.Name = "rxCrcCheckBox";
            this.rxCrcCheckBox.Size = new System.Drawing.Size(157, 17);
            this.rxCrcCheckBox.TabIndex = 9;
            this.rxCrcCheckBox.Text = "Matches Expected Residue";
            this.rxCrcCheckBox.UseVisualStyleBackColor = true;
            // 
            // unescapeCheckBox
            // 
            this.unescapeCheckBox.AutoSize = true;
            this.unescapeCheckBox.Checked = true;
            this.unescapeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.unescapeCheckBox.Location = new System.Drawing.Point(313, 133);
            this.unescapeCheckBox.Name = "unescapeCheckBox";
            this.unescapeCheckBox.Size = new System.Drawing.Size(75, 17);
            this.unescapeCheckBox.TabIndex = 10;
            this.unescapeCheckBox.Text = "Unescape";
            this.unescapeCheckBox.UseVisualStyleBackColor = true;
            this.unescapeCheckBox.CheckedChanged += new System.EventHandler(this.unescapeCheckBox_CheckedChanged);
            // 
            // workingCrcTextBox
            // 
            this.workingCrcTextBox.Location = new System.Drawing.Point(165, 176);
            this.workingCrcTextBox.Name = "workingCrcTextBox";
            this.workingCrcTextBox.Size = new System.Drawing.Size(34, 20);
            this.workingCrcTextBox.TabIndex = 11;
            this.workingCrcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Non-inverted";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // InitalValueTextBox
            // 
            this.InitalValueTextBox.Location = new System.Drawing.Point(73, 22);
            this.InitalValueTextBox.Name = "InitalValueTextBox";
            this.InitalValueTextBox.Size = new System.Drawing.Size(34, 20);
            this.InitalValueTextBox.TabIndex = 2;
            this.InitalValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InitalValueTextBox.Leave += new System.EventHandler(this.InitalValueTextBox_Leave);
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
            // PolynomialTextBox
            // 
            this.PolynomialTextBox.Location = new System.Drawing.Point(186, 22);
            this.PolynomialTextBox.Name = "PolynomialTextBox";
            this.PolynomialTextBox.Size = new System.Drawing.Size(34, 20);
            this.PolynomialTextBox.TabIndex = 2;
            this.PolynomialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PolynomialTextBox.Leave += new System.EventHandler(this.PolynomialTextBox_Leave);
            // 
            // ResidueTextBox
            // 
            this.ResidueTextBox.Location = new System.Drawing.Point(295, 22);
            this.ResidueTextBox.Name = "ResidueTextBox";
            this.ResidueTextBox.Size = new System.Drawing.Size(34, 20);
            this.ResidueTextBox.TabIndex = 2;
            this.ResidueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ResidueTextBox.Leave += new System.EventHandler(this.ResidueTextBox_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Residue";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TermCharTextBox
            // 
            this.TermCharTextBox.Location = new System.Drawing.Point(186, 68);
            this.TermCharTextBox.Name = "TermCharTextBox";
            this.TermCharTextBox.Size = new System.Drawing.Size(34, 20);
            this.TermCharTextBox.TabIndex = 2;
            this.TermCharTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TermCharTextBox.Leave += new System.EventHandler(this.TermCharTextBox_Leave);
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
            this.PostInvertCheckbox.CheckedChanged += new System.EventHandler(this.PostInvertCheckbox_CheckedChanged);
            // 
            // MsBitFirstCheckBox
            // 
            this.MsBitFirstCheckBox.AutoSize = true;
            this.MsBitFirstCheckBox.Checked = true;
            this.MsBitFirstCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MsBitFirstCheckBox.Location = new System.Drawing.Point(9, 48);
            this.MsBitFirstCheckBox.Name = "MsBitFirstCheckBox";
            this.MsBitFirstCheckBox.Size = new System.Drawing.Size(64, 17);
            this.MsBitFirstCheckBox.TabIndex = 10;
            this.MsBitFirstCheckBox.Text = "msb-first";
            this.MsBitFirstCheckBox.UseVisualStyleBackColor = true;
            this.MsBitFirstCheckBox.CheckedChanged += new System.EventHandler(this.MsBitFirstCheckBox_CheckedChanged);
            // 
            // MsByteFirstCheckBox
            // 
            this.MsByteFirstCheckBox.AutoSize = true;
            this.MsByteFirstCheckBox.Checked = true;
            this.MsByteFirstCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MsByteFirstCheckBox.Location = new System.Drawing.Point(79, 48);
            this.MsByteFirstCheckBox.Name = "MsByteFirstCheckBox";
            this.MsByteFirstCheckBox.Size = new System.Drawing.Size(68, 17);
            this.MsByteFirstCheckBox.TabIndex = 10;
            this.MsByteFirstCheckBox.Text = "MSB-first";
            this.MsByteFirstCheckBox.UseVisualStyleBackColor = true;
            this.MsByteFirstCheckBox.CheckedChanged += new System.EventHandler(this.MsByteFirstCheckBox_CheckedChanged);
            // 
            // OmitTermCharCheckBox
            // 
            this.OmitTermCharCheckBox.AutoSize = true;
            this.OmitTermCharCheckBox.Checked = true;
            this.OmitTermCharCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OmitTermCharCheckBox.Location = new System.Drawing.Point(9, 71);
            this.OmitTermCharCheckBox.Name = "OmitTermCharCheckBox";
            this.OmitTermCharCheckBox.Size = new System.Drawing.Size(96, 17);
            this.OmitTermCharCheckBox.TabIndex = 10;
            this.OmitTermCharCheckBox.Text = "Omit TermChar";
            this.OmitTermCharCheckBox.UseVisualStyleBackColor = true;
            this.OmitTermCharCheckBox.CheckedChanged += new System.EventHandler(this.OmitTermCharCheckBox_CheckedChanged);
            // 
            // CrcOptionsGroupBox
            // 
            this.CrcOptionsGroupBox.Controls.Add(this.label6);
            this.CrcOptionsGroupBox.Controls.Add(this.InitalValueTextBox);
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
            this.CrcOptionsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.CrcOptionsGroupBox.Name = "CrcOptionsGroupBox";
            this.CrcOptionsGroupBox.Size = new System.Drawing.Size(339, 98);
            this.CrcOptionsGroupBox.TabIndex = 13;
            this.CrcOptionsGroupBox.TabStop = false;
            this.CrcOptionsGroupBox.Text = "CRC Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 285);
            this.Controls.Add(this.CrcOptionsGroupBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.workingCrcTextBox);
            this.Controls.Add(this.unescapeCheckBox);
            this.Controls.Add(this.rxCrcCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rxCrcTextBox);
            this.Controls.Add(this.txBytesTextBox);
            this.Controls.Add(this.msgCrcTextBox);
            this.Controls.Add(this.msgTextBox);
            this.Name = "Form1";
            this.Text = "CRC tester";
            this.CrcOptionsGroupBox.ResumeLayout(false);
            this.CrcOptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msgTextBox;
        private System.Windows.Forms.TextBox msgCrcTextBox;
        private System.Windows.Forms.TextBox txBytesTextBox;
        private System.Windows.Forms.TextBox rxCrcTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox rxCrcCheckBox;
        private System.Windows.Forms.CheckBox unescapeCheckBox;
        private System.Windows.Forms.TextBox workingCrcTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InitalValueTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PolynomialTextBox;
        private System.Windows.Forms.TextBox ResidueTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TermCharTextBox;
        private System.Windows.Forms.Label TermCharLabel;
        private System.Windows.Forms.CheckBox PostInvertCheckbox;
        private System.Windows.Forms.CheckBox MsBitFirstCheckBox;
        private System.Windows.Forms.CheckBox MsByteFirstCheckBox;
        private System.Windows.Forms.CheckBox OmitTermCharCheckBox;
        private System.Windows.Forms.GroupBox CrcOptionsGroupBox;
    }
}

