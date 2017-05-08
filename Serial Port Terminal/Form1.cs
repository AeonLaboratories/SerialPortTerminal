using HACS.Components;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Utilities;


namespace SerialPortTerminal
{
	public partial class Form1 : Form
    {
        Controller controller;

        string programName;
        string dataFileName = "";
		bool logging;
		LogFile dataLog;

        // UI synchronization
        Queue<string> ResponseQ = new Queue<string>();
        Thread updateThread;
        ManualResetEvent updateSignal = new ManualResetEvent(false);

        public Form1()
        {
            InitializeComponent();

			CrcOptions crcOptions = new CrcOptions();
			InitialValueTextBox.Text = crcOptions.InitialValue.ToString("X4");
			PolynomialTextBox.Text = crcOptions.Polynomial.ToString("X4");
			ResidueTextBox.Text = crcOptions.ExpectedResidue.ToString("X4");
			MsBitFirstCheckBox.Checked = crcOptions.MsBitFirst;
			MsByteFirstCheckBox.Checked = crcOptions.MsByteFirst;
			PostInvertCheckbox.Checked = crcOptions.PostInvert;
			OmitTermCharCheckBox.Checked = crcOptions.OmitTermChar;
			TermCharTextBox.Text = crcOptions.TermChar.ToString("X2");
			TermCharLabel.Visible = TermCharTextBox.Visible = !crcOptions.OmitTermChar;

            Thread.CurrentThread.Name = "UIThread";
			programName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
			
			try
			{
				StreamReader fin = new StreamReader(programName + ".ini");
				dataFileName = fin.ReadLine();
				fin.Close();
			}
			catch { dataFileName = programName + ".txt"; }
			dataLog = new LogFile(dataFileName);
			this.Text = ControllerConfiguration.PortName + " : " + dataFileName;

            updateThread = new Thread(updateUI);
            updateThread.IsBackground = true;
            updateThread.Start();
        }



        private void FormClosingHandler(object sender, FormClosingEventArgs e)
        {
            if (controller != null) controller.Close();    // free serial port
            if (dataLog != null) dataLog.Close();        // terminate writer thread
		}


		void configureController()
		{
			if (controller != null) controller.Close();
			controller = new Controller("", ControllerConfiguration.PortSettings.Clone());
			controller.ResponseProcessor = ProcessControllerResponse;

			CrcOptions crcOptions = new CrcOptions();

			UInt16 n16; int i;  byte b;

			if (UInt16.TryParse(InitialValueTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out n16))
				crcOptions.InitialValue = n16;

			if (UInt16.TryParse(PolynomialTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out n16))
				crcOptions.Polynomial = n16;

			if (UInt16.TryParse(ResidueTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out n16))
				crcOptions.ExpectedResidue = n16;

			crcOptions.MsBitFirst = MsBitFirstCheckBox.Checked;
			crcOptions.MsByteFirst = MsByteFirstCheckBox.Checked;
			crcOptions.PostInvert = PostInvertCheckbox.Checked;
			crcOptions.OmitTermChar = OmitTermCharCheckBox.Checked;

			if (byte.TryParse(TermCharTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out b))
				crcOptions.TermChar = b;

			controller.SerialDevice.CrcConfig = crcOptions;

			if (int.TryParse(bytePaceTextBox.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out i))
				controller.SerialDevice.MillisecondsBetweenBytes = i;

			if (int.TryParse(messagePaceTextBox.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out i))
				controller.SerialDevice.MillisecondsBetweenMessages = i;

			controller.Initialize();
			this.Text = controller.SerialDevice.PortSettings.PortName + " : " + dataFileName;		
		}


		bool controllerConfigured()
		{
			return controller != null &&
				controller.SerialDevice.PortSettings.PortName == ControllerConfiguration.PortSettings.PortName &&
				controller.SerialDevice.PortSettings.BaudRate == ControllerConfiguration.PortSettings.BaudRate &&
				controller.SerialDevice.PortSettings.Parity == ControllerConfiguration.PortSettings.Parity &&
				controller.SerialDevice.PortSettings.DataBits == ControllerConfiguration.PortSettings.DataBits &&
				controller.SerialDevice.PortSettings.StopBits == ControllerConfiguration.PortSettings.StopBits &&
				controller.SerialDevice.PortSettings.Handshake == ControllerConfiguration.PortSettings.Handshake &&

				controller.SerialDevice.MillisecondsBetweenBytes.ToString("0") == bytePaceTextBox.Text &&
				controller.SerialDevice.MillisecondsBetweenMessages.ToString("0") == messagePaceTextBox.Text &&

				controller.SerialDevice.CrcConfig.InitialValue.ToString("X4") == InitialValueTextBox.Text &&
				controller.SerialDevice.CrcConfig.Polynomial.ToString("X4") == PolynomialTextBox.Text &&
				controller.SerialDevice.CrcConfig.ExpectedResidue.ToString("X4") == ResidueTextBox.Text &&
				controller.SerialDevice.CrcConfig.MsBitFirst == MsBitFirstCheckBox.Checked &&
				controller.SerialDevice.CrcConfig.MsByteFirst == MsByteFirstCheckBox.Checked &&
				controller.SerialDevice.CrcConfig.PostInvert == PostInvertCheckbox.Checked &&
				controller.SerialDevice.CrcConfig.OmitTermChar == OmitTermCharCheckBox.Checked &&
				controller.SerialDevice.CrcConfig.TermChar.ToString("X2") == TermCharTextBox.Text;
		}

        private void KeyPressHandler(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape)
            {
                CommandTextBox.Clear();
				txCrcTextBox.Clear();
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
				if (!controllerConfigured())
					configureController();
				string s = System.Text.RegularExpressions.Regex.Unescape(CommandTextBox.Text);
                NotReadyLabel.Visible = !controller.Command(s);
				txCrcTextBox.Text = crcAsText(s);
                e.Handled = true;
            }
        }

		string crcAsText(string s)
		{
			if (controller == null)
				return "";
			Crc crc = new Crc(controller.SerialDevice.CrcConfig);
			crc.Init();
			return crc.Update(s).ToString("X4");
		}

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ReceivedTextBox.Clear();
			rxCrcTextBox.Clear();

			lock (ResponseQ)
			{
				response = "";
				responseBuffer.Clear();
			}

			CommandTextBox.Focus();
        }

		private void fileOpenMenuItem_Click(object sender, EventArgs e)
		{
			openFileDialog1.InitialDirectory = Path.GetDirectoryName(dataFileName);
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				dataFileName = openFileDialog1.FileName;
				StreamWriter fout = new StreamWriter(programName + ".ini");
				fout.WriteLine(dataFileName);
				fout.Close();
				dataLog = new LogFile(dataFileName);
				this.Text = ControllerConfiguration.PortName + " : " +dataFileName;
			}
		}

		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			Application.Exit();
		}

		private void LoggingButton_Click(object sender, EventArgs e)
		{
			logging = !logging;
			LoggingButton.Text = logging ? "Stop Logging" : "Start Logging";
			CommandTextBox.Focus();
		}

        void ProcessControllerResponse(string s)
        {
            lock (ResponseQ) ResponseQ.Enqueue(s);
            updateSignal.Set();
        }

        // this runs in a background thread that's ok to be blocked by the UI
		string response = "";
		StringBuilder responseBuffer = new StringBuilder();
        void updateUI()
        {
            while (!ReceivedTextBox.IsHandleCreated)
                Thread.Sleep(20);

            while (true)
            {
                while (ResponseQ.Count > 0)
                {
                    lock (ResponseQ) response = ResponseQ.Dequeue();
					responseBuffer.Append(response);
					if (logging) dataLog.Write(response);

                    IAsyncResult ar = ReceivedTextBox.BeginInvoke((MethodInvoker)delegate
                    {   // this code is executed in UI thread
						UpdateReceivedTextBox();
                    });
                    ReceivedTextBox.EndInvoke(ar);
                }
                Thread.Sleep(0);
                // wait here until awakened
                updateSignal.Reset();         // reset the signal to the blocking state
                updateSignal.WaitOne();       // wait for signal to be set by ProcessResponse()
            }
        }


		void UpdateReceivedTextBox()
		{
			ReceivedTextBox.AppendText(bytesCheckBox.Checked ? Utility.byte_string(response) : response);
			//ReceivedTextBox.Text = bytesCheckBox.Checked ?
			//	Utility.byte_string(responseBuffer.ToString()) :
			//	responseBuffer.ToString();
			rxCrcTextBox.Text = crcAsText(response);
		}


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (controller != null)
            {
                CommandCountTextBox.Text = controller.CommandCount.ToString();
                ResponseCountTextBox.Text = controller.ResponseCount.ToString();
                BytesReadTextBox.Text = controller.SerialDevice.TotalBytesRead.ToString();
            }
        }


		void bytePaceTextBox_Leave(object sender, EventArgs e)
		{
			int value;
			if (int.TryParse(bytePaceTextBox.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out value))
				bytePaceTextBox.Text = value.ToString("0");
			else if (controller != null)
				bytePaceTextBox.Text = controller.SerialDevice.MillisecondsBetweenBytes.ToString("0");
			else
				bytePaceTextBox.Text = new SerialDevice().MillisecondsBetweenBytes.ToString("0");
		}


		void messagePaceTextBox_Leave(object sender, EventArgs e)
		{
			int value;
			if (int.TryParse(messagePaceTextBox.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out value))
				messagePaceTextBox.Text = value.ToString("0");
			else if (controller != null)
				messagePaceTextBox.Text = controller.SerialDevice.MillisecondsBetweenMessages.ToString("0");
			else
				messagePaceTextBox.Text = new SerialDevice().MillisecondsBetweenMessages.ToString("0");
		}


		void InitialValueTextBox_Leave(object sender, EventArgs e)
		{
			UInt16 value;
			if (UInt16.TryParse(InitialValueTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out value))
				InitialValueTextBox.Text = value.ToString("X4");
			else if (controller != null)
				InitialValueTextBox.Text = controller.SerialDevice.CrcConfig.InitialValue.ToString("X4");
			else
				InitialValueTextBox.Text = new CrcOptions().InitialValue.ToString("X4");
		}

		void PolynomialTextBox_Leave(object sender, EventArgs e)
		{
			UInt16 value;
			if (UInt16.TryParse(PolynomialTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out value))
				PolynomialTextBox.Text = value.ToString("X4");
			else if (controller != null)
				PolynomialTextBox.Text = controller.SerialDevice.CrcConfig.Polynomial.ToString("X4");
			else
				PolynomialTextBox.Text = new CrcOptions().Polynomial.ToString("X4");
		}

		void ResidueTextBox_Leave(object sender, EventArgs e)
		{
			UInt16 value;
			if (UInt16.TryParse(ResidueTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out value))
				ResidueTextBox.Text = value.ToString("X4");
			else if (controller != null)
				ResidueTextBox.Text = controller.SerialDevice.CrcConfig.ExpectedResidue.ToString("X4");
			else
				ResidueTextBox.Text = new CrcOptions().ExpectedResidue.ToString("X4");
		}

		void TermCharTextBox_Leave(object sender, EventArgs e)
		{
			byte value;
			if (byte.TryParse(TermCharTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out value))
				TermCharTextBox.Text = value.ToString("X2");
			else if (controller != null)
				TermCharTextBox.Text = controller.SerialDevice.CrcConfig.TermChar.ToString("X2");
			else
				TermCharTextBox.Text = new CrcOptions().TermChar.ToString("X2");
		}

		private void bytesCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ReceivedTextBox.Text = bytesCheckBox.Checked ? Utility.byte_string(responseBuffer.ToString()) : responseBuffer.ToString();
			ReceivedTextBox.Select(ReceivedTextBox.SelectionStart, 0); //Is this what I want to do?
			//UpdateReceivedTextBox();
		}

		private void OmitTermCharCheckBox_CheckedChanged(object sender, EventArgs e)
		{

			TermCharLabel.Visible = TermCharTextBox.Visible = !OmitTermCharCheckBox.Checked;
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			CommandTextBox.Focus();
		}
	}
}
