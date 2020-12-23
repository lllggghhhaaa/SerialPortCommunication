using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace ArduinoCommunication
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            ReloadPorts();
        }
        private void ReloadPorts()
        {
            portscbox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                portscbox.Items.Add(port);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReloadPorts();
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            new Form1(int.Parse(baudeRatecbox.Text), portscbox.Text, this).Show();
            this.Hide();
        }
    }
}
