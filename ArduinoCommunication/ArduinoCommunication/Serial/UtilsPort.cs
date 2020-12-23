using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCommunication.Serial
{
    public class UtilsPort
    {
        StartForm sForm;
        Form1 form;
        int baudrate;
        string portName;
        SerialPort sPort;
        Logging logger = new Logging();
        public UtilsPort(StartForm sForm, Form1 form, int baudrate, string portName)
        {
            this.sForm = sForm;
            this.form = form;
            this.baudrate = baudrate;
            this.portName = portName;
        }
        public SerialPort port()
        {
            SerialPort port = new SerialPort()
            {
                BaudRate = baudrate,
                PortName = portName
            };
            port.Open();
            port.DataReceived += new SerialDataReceivedEventHandler(ReceiveDataInvoker);
            sPort = port;
            return port;
        }
        public void ReceiveDataInvoker(object o, SerialDataReceivedEventArgs a) { form.logtxt.Invoke(new EventHandler(ReceiveData)); }
        public void ReceiveData(object o, EventArgs e)
        {
            try
            {
                if (form.tStampCheck.Checked)
                    form.logtxt.AppendText($"[{DateTime.UtcNow}] {sPort.ReadLine()}\n");
                else
                    form.logtxt.AppendText(sPort.ReadLine() + "\n");
            }
            catch(Exception err)
            {
                logger.Log(err.ToString());
            }
        }
        public void SendData(string message)
        {
            try
            {
                sPort.WriteLine(message);
            }
            catch(Exception err)
            {
                logger.Log(err.ToString());
            }
        }
        public void Close()
        {
            sPort.Close();
            sForm.Close();
        }
    }
}
