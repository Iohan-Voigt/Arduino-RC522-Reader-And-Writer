namespace LeitorRFID.WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblPortCOM = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.cbxPortCOM = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessageToSend = new System.Windows.Forms.TextBox();
            this.lblMessageToSend = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnReceiveMessage = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 67);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(106, 67);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(96, 23);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblPortCOM
            // 
            this.lblPortCOM.AutoSize = true;
            this.lblPortCOM.Location = new System.Drawing.Point(12, 12);
            this.lblPortCOM.Name = "lblPortCOM";
            this.lblPortCOM.Size = new System.Drawing.Size(63, 15);
            this.lblPortCOM.TabIndex = 2;
            this.lblPortCOM.Text = "Port COM:";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(12, 41);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(60, 15);
            this.lblBaudRate.TabIndex = 3;
            this.lblBaudRate.Text = "Baud rate:";
            // 
            // cbxPortCOM
            // 
            this.cbxPortCOM.FormattingEnabled = true;
            this.cbxPortCOM.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.cbxPortCOM.Location = new System.Drawing.Point(81, 9);
            this.cbxPortCOM.Name = "cbxPortCOM";
            this.cbxPortCOM.Size = new System.Drawing.Size(121, 23);
            this.cbxPortCOM.TabIndex = 4;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Items.AddRange(new object[] {
            "9600"});
            this.cbxBaudRate.Location = new System.Drawing.Point(81, 38);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(121, 23);
            this.cbxBaudRate.TabIndex = 5;
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(208, 67);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(307, 165);
            this.rtbData.TabIndex = 6;
            this.rtbData.Text = "";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(12, 93);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(106, 15);
            this.lblConnectionStatus.TabIndex = 7;
            this.lblConnectionStatus.Text = "Connection status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(124, 93);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 15);
            this.lblStatus.TabIndex = 8;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 108);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 15);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Message";
            // 
            // txtMessageToSend
            // 
            this.txtMessageToSend.Location = new System.Drawing.Point(321, 9);
            this.txtMessageToSend.Name = "txtMessageToSend";
            this.txtMessageToSend.Size = new System.Drawing.Size(194, 23);
            this.txtMessageToSend.TabIndex = 10;
            // 
            // lblMessageToSend
            // 
            this.lblMessageToSend.AutoSize = true;
            this.lblMessageToSend.Location = new System.Drawing.Point(217, 12);
            this.lblMessageToSend.Name = "lblMessageToSend";
            this.lblMessageToSend.Size = new System.Drawing.Size(98, 15);
            this.lblMessageToSend.TabIndex = 11;
            this.lblMessageToSend.Text = "Message to send:";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(217, 37);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(96, 23);
            this.btnSendMessage.TabIndex = 12;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnReceiveMessage
            // 
            this.btnReceiveMessage.Enabled = false;
            this.btnReceiveMessage.Location = new System.Drawing.Point(321, 37);
            this.btnReceiveMessage.Name = "btnReceiveMessage";
            this.btnReceiveMessage.Size = new System.Drawing.Size(108, 23);
            this.btnReceiveMessage.TabIndex = 13;
            this.btnReceiveMessage.Text = "Receive Message";
            this.btnReceiveMessage.UseVisualStyleBackColor = true;
            this.btnReceiveMessage.Click += new System.EventHandler(this.btnReceiveMessage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 244);
            this.Controls.Add(this.btnReceiveMessage);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.lblMessageToSend);
            this.Controls.Add(this.txtMessageToSend);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.cbxBaudRate);
            this.Controls.Add(this.cbxPortCOM);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.lblPortCOM);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConnect;
        private Button btnDisconnect;
        private Label lblPortCOM;
        private Label lblBaudRate;
        private ComboBox cbxPortCOM;
        private ComboBox cbxBaudRate;
        public RichTextBox rtbData;
        private Label lblConnectionStatus;
        private Label lblStatus;
        private Label lblMessage;
        private TextBox txtMessageToSend;
        private Label lblMessageToSend;
        private Button btnSendMessage;
        private Button btnReceiveMessage;
        private System.Windows.Forms.Timer timer1;
    }
}