namespace Serial_Communication
{
    partial class Serial
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.cbRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMonitor = new System.Windows.Forms.RichTextBox();
            this.btnLEDON = new System.Windows.Forms.Button();
            this.btnLEDOFF = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnConn = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(87, 13);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 20);
            this.cbPort.TabIndex = 0;
            // 
            // cbRate
            // 
            this.cbRate.FormattingEnabled = true;
            this.cbRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbRate.Location = new System.Drawing.Point(87, 39);
            this.cbRate.Name = "cbRate";
            this.cbRate.Size = new System.Drawing.Size(121, 20);
            this.cbRate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate :";
            // 
            // txtSend
            // 
            this.txtSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSend.Location = new System.Drawing.Point(12, 94);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(196, 21);
            this.txtSend.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 121);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(196, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSend_MouseDown);
            // 
            // txtMonitor
            // 
            this.txtMonitor.Location = new System.Drawing.Point(12, 150);
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.Size = new System.Drawing.Size(196, 186);
            this.txtMonitor.TabIndex = 5;
            this.txtMonitor.Text = "";
            this.txtMonitor.TextChanged += new System.EventHandler(this.txtMonitor_TextChanged);
            // 
            // btnLEDON
            // 
            this.btnLEDON.Location = new System.Drawing.Point(12, 342);
            this.btnLEDON.Name = "btnLEDON";
            this.btnLEDON.Size = new System.Drawing.Size(196, 23);
            this.btnLEDON.TabIndex = 6;
            this.btnLEDON.Text = "LED ON";
            this.btnLEDON.UseVisualStyleBackColor = true;
            this.btnLEDON.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLEDON_MouseDown);
            // 
            // btnLEDOFF
            // 
            this.btnLEDOFF.Location = new System.Drawing.Point(12, 371);
            this.btnLEDOFF.Name = "btnLEDOFF";
            this.btnLEDOFF.Size = new System.Drawing.Size(196, 23);
            this.btnLEDOFF.TabIndex = 6;
            this.btnLEDOFF.Text = "LED OFF";
            this.btnLEDOFF.UseVisualStyleBackColor = true;
            this.btnLEDOFF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLEDOFF_MouseDown);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(12, 65);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(196, 23);
            this.btnConn.TabIndex = 7;
            this.btnConn.Text = "Connect";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnConn_MouseDown);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // Serial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(222, 406);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.btnLEDOFF);
            this.Controls.Add(this.btnLEDON);
            this.Controls.Add(this.txtMonitor);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRate);
            this.Controls.Add(this.cbPort);
            this.Name = "Serial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Serial_FormClosed);
            this.Load += new System.EventHandler(this.Serial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.ComboBox cbRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox txtMonitor;
        private System.Windows.Forms.Button btnLEDON;
        private System.Windows.Forms.Button btnLEDOFF;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Timer timerUpdate;
    }
}

