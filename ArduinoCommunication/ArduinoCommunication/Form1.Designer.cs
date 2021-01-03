
using ArduinoCommunication.Serial;

namespace ArduinoCommunication
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.logtxt = new System.Windows.Forms.TextBox();
            this.tStampCheck = new System.Windows.Forms.CheckBox();
            this.Terminalbtn = new System.Windows.Forms.Button();
            this.shownametxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(12, 537);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(477, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.MouseHover += new System.EventHandler(this.textBox2_MouseHover);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(513, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // logtxt
            // 
            this.logtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logtxt.BackColor = System.Drawing.Color.Black;
            this.logtxt.ForeColor = System.Drawing.Color.White;
            this.logtxt.Location = new System.Drawing.Point(12, 53);
            this.logtxt.Multiline = true;
            this.logtxt.Name = "logtxt";
            this.logtxt.ReadOnly = true;
            this.logtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logtxt.Size = new System.Drawing.Size(576, 455);
            this.logtxt.TabIndex = 3;
            this.logtxt.MouseHover += new System.EventHandler(this.logtxt_MouseHover);
            // 
            // tStampCheck
            // 
            this.tStampCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tStampCheck.AutoSize = true;
            this.tStampCheck.BackColor = System.Drawing.Color.Black;
            this.tStampCheck.ForeColor = System.Drawing.Color.White;
            this.tStampCheck.Location = new System.Drawing.Point(12, 514);
            this.tStampCheck.Name = "tStampCheck";
            this.tStampCheck.Size = new System.Drawing.Size(107, 17);
            this.tStampCheck.TabIndex = 6;
            this.tStampCheck.Text = "Show Timestamp";
            this.tStampCheck.UseVisualStyleBackColor = false;
            this.tStampCheck.MouseHover += new System.EventHandler(this.tStampCheck_MouseHover);
            // 
            // Terminalbtn
            // 
            this.Terminalbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Terminalbtn.BackColor = System.Drawing.Color.Black;
            this.Terminalbtn.ForeColor = System.Drawing.Color.White;
            this.Terminalbtn.Location = new System.Drawing.Point(513, 12);
            this.Terminalbtn.Name = "Terminalbtn";
            this.Terminalbtn.Size = new System.Drawing.Size(75, 35);
            this.Terminalbtn.TabIndex = 7;
            this.Terminalbtn.Text = "Terminal";
            this.Terminalbtn.UseVisualStyleBackColor = false;
            this.Terminalbtn.Click += new System.EventHandler(this.button2_Click);
            this.Terminalbtn.MouseHover += new System.EventHandler(this.Terminalbtn_MouseHover);
            // 
            // shownametxt
            // 
            this.shownametxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shownametxt.BackColor = System.Drawing.Color.Black;
            this.shownametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shownametxt.ForeColor = System.Drawing.Color.White;
            this.shownametxt.Location = new System.Drawing.Point(3, 573);
            this.shownametxt.Name = "shownametxt";
            this.shownametxt.Size = new System.Drawing.Size(576, 13);
            this.shownametxt.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(600, 588);
            this.Controls.Add(this.shownametxt);
            this.Controls.Add(this.Terminalbtn);
            this.Controls.Add(this.tStampCheck);
            this.Controls.Add(this.logtxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox logtxt;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.CheckBox tStampCheck;
        private System.Windows.Forms.Button Terminalbtn;
        public System.Windows.Forms.TextBox shownametxt;
    }
}

