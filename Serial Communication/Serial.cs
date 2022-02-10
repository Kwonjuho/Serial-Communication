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

namespace Serial_Communication
{
    public partial class Serial : Form
    {
        public Serial()
        {
            InitializeComponent();
        }

        private void Serial_Load(object sender, EventArgs e)
        {
            try
            {
                string[] PortName = SerialPort.GetPortNames();                                  // * 연결된 포트 검색

                foreach (string Port in PortName)
                {
                    cbPort.Items.Add(Port);                                                     // * 검색된 포트 콤보박스에 추가
                }
                cbPort.SelectedIndex = 0;                                                       // * 콤보박스 0번째 선택
                cbRate.SelectedIndex = 0;
            }
            catch { }
        }

        // * 포트 연결 메소드
        private void SerialPortOpen()
        {
            try
            {
                serialPort1.PortName = cbPort.Text;
                serialPort1.BaudRate = Int32.Parse(cbRate.Text);

                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    MessageBox.Show("연결성공", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cbPort.Enabled = false;
                    cbRate.Enabled = false;
                }
            }
            catch
            {
                serialPort1.Close();
                MessageBox.Show("연결해제", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                cbPort.Enabled = true;
                cbRate.Enabled = true;
            }
        }

        private void btnConn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SerialPortOpen();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string sendStr = serialPort1.ReadLine() + "\n";
            BeginInvoke(new WriteCallback(WriteText), new object[] { sendStr });
        }

        // * 메인 / 수신 스레드 충돌 방지
        private void WriteText(string str)
        {
            this.txtMonitor.AppendText(str);
        }
        delegate void WriteCallback(string str);

        string Date;

        // * 전송 버튼
        private void btnSend_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (serialPort1.IsOpen)
                {
                    try
                    {
                        if (txtSend.Text != "")
                        {
                            Date = DateTime.Now.ToString("==== yyyy-MM-dd HH:mm:ss ====");
                            txtMonitor.AppendText(Date + '\n');
                            serialPort1.WriteLine(txtSend.Text.ToString()); // * 문자 전송
                        }
                        else
                        {
                            MessageBox.Show("입력해주세요.", "알림",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch { }
                }
                else
                {
                    MessageBox.Show("연결이 해제된 상태입니다.", "알림",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // * 아두이노 내장LED 제어
        private void btnLEDON_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (serialPort1.IsOpen)
                {
                    try
                    {
                        txtMonitor.AppendText(Date + '\n');
                        serialPort1.WriteLine("ON");
                    }
                    catch { }
                }
            }
        }
        private void btnLEDOFF_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (serialPort1.IsOpen)
                {
                    try
                    {
                        txtMonitor.AppendText(Date + '\n');
                        serialPort1.WriteLine("OFF");
                    }
                    catch { }
                }
            }
        }

        // * 날짜 타이머
        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            Date = DateTime.Now.ToString("==== yyyy-MM-dd HH:mm:ss ====");
        }

        // * 텍스트박스 스크롤 자동내리기
        private void txtMonitor_TextChanged(object sender, EventArgs e)
        {
            txtMonitor.SelectionStart = txtMonitor.TextLength;
            txtMonitor.ScrollToCaret();
        }

        // * 종료
        private void Serial_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (true == serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
    }
}
