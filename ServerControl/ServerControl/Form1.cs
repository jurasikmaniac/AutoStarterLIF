using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace ServerControl
{
    public partial class Form1 : Form
    {
        public int MAXCOUNT = 60;
        private int _badReceiveCount = 0;
        public int badReceiveCount
        {
            get
            {
                return _badReceiveCount;
            }
            set
            {
                _badReceiveCount = value;
                countBox.Text = _badReceiveCount.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                button1.Text = "Stop";
                timer1.Enabled = true;
                badReceiveCount = 0;
                WriteToConsole("Старт проверки сервера на адэкватность через каждые 5 секунд");
            }
            else
            {
                button1.Text = "Start";
                timer1.Enabled = false;
            }
        }

        private void WriteToConsole(String str)
        {
            if (str.Length == 0)
            {
                return;
            }
            if (consoleBox.TextLength > 10000)
            {
                consoleBox.Text = "";
            }
            consoleBox.AppendText(str + "\n");
            consoleBox.SelectionStart = consoleBox.Text.Length;
            consoleBox.ScrollToCaret();
        }

        private bool CheckServerLIF(String address, int port) {
            byte sendByte = 0x0E;
            bool started = false;
            byte[] sendPackage = new byte[1] { sendByte };
            UdpClient client = new UdpClient();
            client.Client.SendTimeout = 1000;
            client.Client.ReceiveTimeout = 1000;
            try
            {
                client.Send(sendPackage, sendPackage.Length, address, port);
               // WriteToConsole("Send check byte to server " + address + ":" + port.ToString());
                IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] rcvPacket = client.Receive(ref remoteIPEndPoint);
                 
                //WriteToConsole("Receive bytes " + rcvPacket.Length.ToString() + " " + remoteIPEndPoint.ToString() + ":" +
                //    string.Join(string.Empty, Array.ConvertAll(rcvPacket, b => b.ToString("X2"))));
                started = true;
            }
            catch (SocketException se)
            {
                WriteToConsole(se.ErrorCode.ToString() + ": " + se.Message);
                started = false;
            }
            client.Close();
            return started;
        }


        private void InitializeTimer()
        {
            // Call this procedure when the application starts.
            // Set to 5 second.
            timer1.Interval = 5000;
            timer1.Tick += new EventHandler(timer1_Tick);

            // Enable timer.
            timer1.Enabled = false;

            button1.Text = "Start";
            button1.Click += new EventHandler(button1_Click);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WriteToConsole(ipAddressBox.Text + ":" + portBox.Text);
            int port = 0;
            int.TryParse(portBox.Text, out port);
            

            Process[] notepads;
            notepads = Process.GetProcessesByName("ddctd_cm_yo_server");
            // Test to see if the process is responding.
            try {
                if (notepads[0].Responding)
                {
                    //notepads[0].CloseMainWindow();
                    WriteToConsole("Сервер отвечает на запросы системы");
                    if (CheckServerLIF(ipAddressBox.Text, port))
                    {
                        WriteToConsole("Сервер активен");
                        badReceiveCount = 0;
                    }
                    else
                    {
                        WriteToConsole("Сервер не активен");
                        badReceiveCount++;
                        if (badReceiveCount>MAXCOUNT)
                        {
                            WriteToConsole("Сервер не отвечает на запросы, килл хим!");
                            notepads[0].Kill();
                            badReceiveCount = 0;


                        }
                    }
                }
                else
                {
                    WriteToConsole("Сервер не отвечает на запросы, килл хим!");                    
                    notepads[0].Kill();
                    badReceiveCount = 0;
                }
            }
            catch(Exception ex)
            {
                WriteToConsole("Сервер не запущен! Пробуем запустить.");
                try
                {
                    Process.Start(serverFileName.Text);
                    badReceiveCount = 0;
                }
                catch (Exception se)
                {
                    WriteToConsole(se.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            string fileName;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Server exe (*.exe)|*.exe";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    if ((fileName = openFileDialog1.FileName) != null)
                    {
                        serverFileName.Text = openFileDialog1.FileName;
                    }
                }
                catch (Exception se)
                {
                    WriteToConsole(se.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MAXCOUNT = Decimal.ToInt32(maxCountUpDown.Value);
        }
    }
}
