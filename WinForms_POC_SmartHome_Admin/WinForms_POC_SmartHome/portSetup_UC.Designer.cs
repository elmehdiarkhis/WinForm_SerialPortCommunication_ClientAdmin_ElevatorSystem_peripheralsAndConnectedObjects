namespace WinForms_POC_SmartHome
{
    partial class portSetup_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtDataBits = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtParity = new System.Windows.Forms.TextBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Location = new System.Drawing.Point(342, 258);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(143, 40);
            this.cboStopBits.TabIndex = 39;
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(342, 140);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(143, 40);
            this.cboParity.TabIndex = 38;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(13, 259);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(337, 39);
            this.textBox8.TabIndex = 37;
            this.textBox8.Text = "stopBits  (silence entre block) : ";
            // 
            // txtDataBits
            // 
            this.txtDataBits.Location = new System.Drawing.Point(342, 201);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(143, 39);
            this.txtDataBits.TabIndex = 36;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(13, 201);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(337, 39);
            this.textBox6.TabIndex = 35;
            this.textBox6.Text = "DataBits  (byte par block) : ";
            // 
            // txtParity
            // 
            this.txtParity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParity.Enabled = false;
            this.txtParity.Location = new System.Drawing.Point(13, 140);
            this.txtParity.Name = "txtParity";
            this.txtParity.Size = new System.Drawing.Size(337, 39);
            this.txtParity.TabIndex = 34;
            this.txtParity.Text = "Parity (marge d\'erreur) : ";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(342, 79);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(143, 39);
            this.txtBaudRate.TabIndex = 33;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(13, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(337, 39);
            this.textBox3.TabIndex = 32;
            this.textBox3.Text = "BaudRate (byteperSecond) : ";
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(342, 19);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(143, 40);
            this.cboPorts.TabIndex = 29;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(13, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 39);
            this.textBox2.TabIndex = 28;
            this.textBox2.Text = "le nom du port a configurer : ";
            // 
            // portSetup_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboStopBits);
            this.Controls.Add(this.cboParity);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txtDataBits);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtParity);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.textBox2);
            this.Name = "portSetup_UC";
            this.Size = new System.Drawing.Size(501, 319);
            this.Load += new System.EventHandler(this.portSetup_UC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboStopBits;
        private ComboBox cboParity;
        private TextBox textBox8;
        private TextBox txtDataBits;
        private TextBox textBox6;
        private TextBox txtParity;
        private TextBox txtBaudRate;
        private TextBox textBox3;
        private ComboBox cboPorts;
        private TextBox textBox2;
    }
}
