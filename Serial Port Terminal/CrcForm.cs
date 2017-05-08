using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace CRC_tester
{
    public partial class CrcForm : Form
    {
        CrcOptions options;

        public CrcForm()
        {
            InitializeComponent();

            // Aeon convention
            options = new CrcOptions();     // default

            // Eurotherm convention
            //options = new CrcOptions(0xFFFF, 0xA001, 0x0000, false, true, true, 0, true);

            InitalValueTextBox.Text = options.InitialValue.ToString("X4");
            PolynomialTextBox.Text = options.Polynomial.ToString("X4");
            ResidueTextBox.Text = options.ExpectedResidue.ToString("X4");
            MsBitFirstCheckBox.Checked = options.MsBitFirst;
            MsByteFirstCheckBox.Checked = options.MsByteFirst;
            OmitTermCharCheckBox.Checked = options.OmitTermChar;
            TermCharTextBox.Text = options.TermChar.ToString("X2");
            TermCharLabel.Visible = TermCharTextBox.Visible = !options.OmitTermChar;
            updateDisplay();
        }


        void msg_TextChanged(object sender, EventArgs e)
        { updateDisplay(); }

        void unescapeCheckBox_CheckedChanged(object sender, EventArgs e)
        { updateDisplay(); }

        void updateDisplay()
        {
            Crc txCrc = new Crc(options);
            string msg = unescapeCheckBox.Checked ?
                System.Text.RegularExpressions.Regex.Unescape(msgTextBox.Text) :
                msgTextBox.Text;
            string send =   txCrc.sAppend(msg);

			UInt16 currentCrc = txCrc.Code;
			workingCrcTextBox.Text = currentCrc.ToString("X4");
			
			if (options.PostInvert)
                msgCrcTextBox.Text = ((UInt16)(~currentCrc)).ToString("X4");
            else
                msgCrcTextBox.Text = workingCrcTextBox.Text;

            txBytesTextBox.Text = byte_string(send);

            Crc rxCrc = new Crc(options);
            if (options.OmitTermChar)
                rxCrc.Update(send.Substring(0, send.Length));
            else
                rxCrc.Update(send.Substring(0, send.Length - 1));
            rxCrcTextBox.Text = rxCrc.Code.ToString("X4");
            rxCrcCheckBox.Checked = rxCrc.Good();

        }

		string byte_string(string s)
		{
            StringBuilder sb = new StringBuilder();
            foreach (byte b in s)
            {
                sb.Append(b.ToString("X2"));
                sb.Append(" ");
            }
            return sb.ToString().TrimEnd();
		}


        void InitalValueTextBox_Leave(object sender, EventArgs e)
        {
            UInt16 value;
            if (UInt16.TryParse(InitalValueTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out value))
            {
                options.InitialValue = value;
                updateDisplay();
            }
            InitalValueTextBox.Text = options.InitialValue.ToString("X4");
        }

        void PolynomialTextBox_Leave(object sender, EventArgs e)
        {
            UInt16 value;
            if (UInt16.TryParse(PolynomialTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out value))
            {
                options.Polynomial = value;
                updateDisplay();
            }
            PolynomialTextBox.Text = options.Polynomial.ToString("X4");
        }

        void ResidueTextBox_Leave(object sender, EventArgs e)
        {
            UInt16 value;
            if (UInt16.TryParse(ResidueTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out value))
            {
                options.ExpectedResidue = value;
                updateDisplay();
            }
            ResidueTextBox.Text = options.ExpectedResidue.ToString("X4");
        }

        void MsBitFirstCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            options.MsBitFirst = MsBitFirstCheckBox.Checked;
            updateDisplay();
        }

        void MsByteFirstCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            options.MsByteFirst = MsByteFirstCheckBox.Checked;
            updateDisplay();
        }

        void PostInvertCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            options.PostInvert = PostInvertCheckbox.Checked;
            updateDisplay();
        }

        void OmitTermCharCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            options.OmitTermChar = OmitTermCharCheckBox.Checked;
            TermCharLabel.Visible = TermCharTextBox.Visible = !OmitTermCharCheckBox.Checked;
            updateDisplay();
        }

        void TermCharTextBox_Leave(object sender, EventArgs e)
        {
            byte value;
            if (byte.TryParse(TermCharTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out value))
            {
                options.TermChar = value;
                updateDisplay();
            }
            TermCharTextBox.Text = options.TermChar.ToString("X2");
        }
    }
}
