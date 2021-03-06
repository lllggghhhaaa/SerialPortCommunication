﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // portscbox
            // 
            this.portscbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portscbox.BackColor = System.Drawing.Color.Black;
            this.portscbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portscbox.ForeColor = System.Drawing.SystemColors.Menu;
            this.portscbox.FormattingEnabled = true;
            this.portscbox.Location = new System.Drawing.Point(12, 85);
            this.portscbox.Name = "portscbox";
            this.portscbox.Size = new System.Drawing.Size(206, 21);
            this.portscbox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(224, 76);
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
            this.connectbtn.Location = new System.Drawing.Point(224, 347);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(75, 37);
            this.connectbtn.TabIndex = 2;
            this.connectbtn.Text = "Conectar";
            this.connectbtn.UseVisualStyleBackColor = false;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // baudeRatecbox
            // 
            this.baudeRatecbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.baudeRatecbox.Size = new System.Drawing.Size(287, 21);
            this.baudeRatecbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "BaudRate:";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(311, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baudeRatecbox);
            this.Controls.Add(this.connectbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.portscbox);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portscbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.ComboBox baudeRatecbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}