
namespace ArduinoCommunication
{
    partial class StartForm
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
            this.portscbox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.connectbtn = new System.Windows.Forms.Button();
            this.baudeRatecbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // portscbox
            // 
            this.portscbox.BackColor = System.Drawing.Color.Black;
            this.portscbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portscbox.ForeColor = System.Drawing.SystemColors.Menu;
            this.portscbox.FormattingEnabled = true;
            this.portscbox.Location = new System.Drawing.Point(12, 85);
            this.portscbox.Name = "portscbox";
            this.portscbox.Size = new System.Drawing.Size(230, 21);
            this.portscbox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(248, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // connectbtn
            // 
            this.connectbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.connectbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.connectbtn.Location = new System.Drawing.Point(248, 401);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(75, 37);
            this.connectbtn.TabIndex = 2;
            this.connectbtn.Text = "Conectar";
            this.connectbtn.UseVisualStyleBackColor = false;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // baudeRatecbox
            // 
            this.baudeRatecbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.baudeRatecbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudeRatecbox.ForeColor = System.Drawing.SystemColors.Menu;
            this.baudeRatecbox.FormattingEnabled = true;
            this.baudeRatecbox.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.baudeRatecbox.Location = new System.Drawing.Point(12, 143);
            this.baudeRatecbox.Name = "baudeRatecbox";
            this.baudeRatecbox.Size = new System.Drawing.Size(103, 21);
            this.baudeRatecbox.TabIndex = 3;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.baudeRatecbox);
            this.Controls.Add(this.connectbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.portscbox);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox portscbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.ComboBox baudeRatecbox;
    }
}