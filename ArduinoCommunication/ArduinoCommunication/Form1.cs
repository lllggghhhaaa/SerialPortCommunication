using ArduinoCommunication.Serial;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace ArduinoCommunication
{
    public partial class Form1 : Form
    {
        public StartForm startform;
        SerialPort port;
        UtilsPort util;
        private Queue<byte> recievedData = new Queue<byte>();

        public Form1(int baudRate, string portString, StartForm startform)
        {
            InitializeComponent();
            if(port == null)
            {
                this.startform = startform;
                util = new UtilsPort(startform, this, baudRate, portString);
                port = util.port();
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            util.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            util.SendData(textBox2.Text);
            textBox2.Text = String.Empty;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                util.SendData(textBox2.Text);
                textBox2.Text = String.Empty;
            }
        }
    }
}