using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoCommunication
{
    public partial class Terminal : Form
    {
        Form1 form;
        public Terminal(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(commandtxt.Text.StartsWith("/"))
            {
                string[] args = commandtxt.Text.Split(' ');
                switch(args[0])
                {
                    case "/move":
                        var ob = form.Controls.Find(args[1], true).First();

                        if (int.TryParse(args[2], out int x) && int.TryParse(args[3], out int y))
                        {
                            ob.Location = new Point(x, y);
                            logtxt.AppendText($"\nObjeto movido para {x}x, {y}y");
                            commandtxt.Text = String.Empty;
                        }
                        else
                        {
                            logtxt.AppendText($"\nErro ao converter x e y");
                            commandtxt.Text = String.Empty;
                        }
                        break;
                    case "/sum":
                        string expression = $"{args[1]} {args[2]} {args[3]}";
                        logtxt.AppendText($"\n{expression} = {Evaluate(expression)}");
                        commandtxt.Text = String.Empty;
                        break;
                }
            }
            else
            {
                logtxt.AppendText("\n" + commandtxt.Text);
                commandtxt.Text = String.Empty;
            }
        }
       private static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
    }
}
