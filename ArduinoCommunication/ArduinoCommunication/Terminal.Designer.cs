
namespace ArduinoCommunication
{
    partial class Terminal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.commandtxt = new System.Windows.Forms.TextBox();
            this.logtxt = new System.Windows.Forms.TextBox();
            this.exebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commandtxt
            // 
            this.commandtxt.BackColor = System.Drawing.Color.Black;
            this.commandtxt.ForeColor = System.Drawing.Color.White;
            this.commandtxt.Location = new System.Drawing.Point(12, 418);
            this.commandtxt.Name = "commandtxt";
            this.commandtxt.Size = new System.Drawing.Size(695, 20);
            this.commandtxt.TabIndex = 0;
            // 
            // logtxt
            // 
            this.logtxt.BackColor = System.Drawing.Color.Black;
            this.logtxt.ForeColor = System.Drawing.Color.White;
            this.logtxt.Location = new System.Drawing.Point(12, 12);
            this.logtxt.Multiline = true;
            this.logtxt.Name = "logtxt";
            this.logtxt.ReadOnly = true;
            this.logtxt.Size = new System.Drawing.Size(776, 360);
            this.logtxt.TabIndex = 1;
            // 
            // exebtn
            // 
            this.exebtn.BackColor = System.Drawing.Color.Black;
            this.exebtn.Location = new System.Drawing.Point(713, 411);
            this.exebtn.Name = "exebtn";
            this.exebtn.Size = new System.Drawing.Size(75, 33);
            this.exebtn.TabIndex = 2;
            this.exebtn.Text = "Executar";
            this.exebtn.UseVisualStyleBackColor = false;
            this.exebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exebtn);
            this.Controls.Add(this.logtxt);
            this.Controls.Add(this.commandtxt);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Terminal";
            this.Text = "Terminal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox commandtxt;
        private System.Windows.Forms.TextBox logtxt;
        private System.Windows.Forms.Button exebtn;
    }
}