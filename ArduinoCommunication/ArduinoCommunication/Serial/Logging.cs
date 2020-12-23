using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCommunication.Serial
{
    public class Logging
    {
        public void Log(string message)
        {
            if(File.Exists(Environment.CurrentDirectory))
            {
                StreamWriter fw = File.AppendText(Environment.CurrentDirectory);
                fw.WriteLine($"[{DateTime.UtcNow}]: {message}");
            }
            else
            {
                FileStream fs = File.Create(Environment.CurrentDirectory);
                StreamWriter fw = new StreamWriter(fs);
                fw.WriteLine($"[{DateTime.UtcNow}]: {message}");
            }
        }
    }
}
