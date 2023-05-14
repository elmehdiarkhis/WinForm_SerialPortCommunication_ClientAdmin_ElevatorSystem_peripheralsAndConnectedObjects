namespace WinForms_POC_SmartHome
{
    partial class frmPortSetup
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstPorts = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.txtParity = new System.Windows.Forms.TextBox();
            this.txtDataBits = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 495);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 39);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Les Ports disponible sur cette machine :";
            // 
            // lstPorts
            // 
            this.lstPorts.FormattingEnabled = true;
            this.lstPorts.ItemHeight = 32;
            this.lstPorts.Location = new System.Drawing.Point(12, 540);
            this.lstPorts.Name = "lstPorts";
            this.lstPorts.Size = new System.Drawing.Size(457, 100);
            this.lstPorts.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(20, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(417, 39);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "le nom du port a configurer : ";
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(467, 39);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(242, 40);
            this.cboPorts.TabIndex = 4;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Green;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpen.Location = new System.Drawing.Point(20, 349);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(200, 46);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Ouvrir le Port";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(773, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Fermer le Port";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(20, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(417, 39);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "BaudRate (byteperSecond) : ";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(467, 99);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(242, 39);
            this.txtBaudRate.TabIndex = 8;
            // 
            // txtParity
            // 
            this.txtParity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParity.Enabled = false;
            this.txtParity.Location = new System.Drawing.Point(20, 160);
            this.txtParity.Name = "txtParity";
            this.txtParity.Size = new System.Drawing.Size(417, 39);
            this.txtParity.TabIndex = 9;
            this.txtParity.Text = "Parity (marge d\'erreur) : ";
            // 
            // txtDataBits
            // 
            this.txtDataBits.Location = new System.Drawing.Point(467, 221);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(242, 39);
            this.txtDataBits.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(20, 221);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(417, 39);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "DataBits  (nombre de byte par block) : ";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(20, 279);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(417, 39);
            this.textBox8.TabIndex = 13;
            this.textBox8.Text = "stopBits  (silence entre block) : ";
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(467, 160);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(242, 40);
            this.cboParity.TabIndex = 14;
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Location = new System.Drawing.Point(467, 279);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(242, 40);
            this.cboStopBits.TabIndex = 15;
            // 
            // frmPortSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 652);
            this.Controls.Add(this.cboStopBits);
            this.Controls.Add(this.cboParity);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txtDataBits);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtParity);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lstPorts);
            this.Controls.Add(this.textBox1);
            this.Name = "frmPortSetup";
            this.Text = "frmPortSetup";
            this.Load += new System.EventHandler(this.frmPortSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private ListBox lstPorts;
        private TextBox textBox2;
        private ComboBox cboPorts;
        private Button btnOpen;
        private Button button1;
        private TextBox textBox3;
        private TextBox txtBaudRate;
        private TextBox txtParity;
        private TextBox txtDataBits;
        private TextBox textBox6;
        private TextBox textBox8;
        private ComboBox cboParity;
        private ComboBox cboStopBits;
    }
}