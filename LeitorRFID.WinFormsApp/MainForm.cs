using System.IO.Ports;

namespace LeitorRFID.WinFormsApp
{
    public partial class MainForm : Form
    {
        public SerialPort sPort;
        public Thread thread;
        public MainForm instance;
        public string messageRecived;

        public MainForm()
        {
            instance = this;
            sPort = new SerialPort();           
            InitializeComponent();
            StartConfigurations();
            thread = new Thread(WriteOnBoar);
            thread.Start();
        }

        public void WriteOnBoar()
        {
            string message = "";

            while (true)
            {
                if (sPort.IsOpen)
                {
                    message = sPort.ReadLine();
                    messageRecived = message;
                    Write(message);
                }
                message = "";
            }
        }
        delegate void UpdateRtbData(string message);
        void Write(string message)
        {
            if (InvokeRequired)
            {
                UpdateRtbData updateRtbData = Write;
                Invoke(updateRtbData, message);
            }
            else
            {
                this.rtbData.Text += message;
            }
        }

        private void StartConfigurations()
        {
            cbxPortCOM.Items.Clear();

            if (SerialPort.GetPortNames().Count() == 0)
            {
                lblMessage.Text = "Any Port Detected";
            }
            else
            {
                foreach (string portName in SerialPort.GetPortNames())
                {
                    cbxPortCOM.Items.Add(portName);
                }
            }
            cbxPortCOM.SelectedIndex = 0;

            cbxBaudRate.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                sPort.PortName = cbxPortCOM.SelectedItem.ToString();
                sPort.BaudRate = Int16.Parse(cbxBaudRate.SelectedItem.ToString());

                if(sPort.IsOpen)
                    sPort.Close();
                sPort.Open();
                lblMessage.Text = $"Port: {sPort.PortName} Opened";
                btnSendMessage.Enabled = true;
                btnReceiveMessage.Enabled = true;
                timer1.Start();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
                btnSendMessage.Enabled = false;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                sPort.Close();
                lblMessage.Text = $"Port: {sPort.PortName} Disconnected";
                btnSendMessage.Enabled = false;
                btnReceiveMessage.Enabled = false;
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txtMessageToSend.Text;
                sPort.Write(message + "\n");
                lblMessage.Text = "Message Sent!";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }           
        }

        private void btnReceiveMessage_Click(object sender, EventArgs e)
        {
            int tries = 0;
            string message = "";

            while (tries < 15)
            {
                if(sPort.IsOpen)
                {
                    message = sPort.ReadLine();
                    rtbData.Text += message;
                }
                message = "";
                tries++;
            }
        }
    }
}