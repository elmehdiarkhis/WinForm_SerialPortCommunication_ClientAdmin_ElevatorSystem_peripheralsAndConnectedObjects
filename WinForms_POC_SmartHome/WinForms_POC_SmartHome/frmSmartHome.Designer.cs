namespace WinForms_POC_SmartHome
{
    partial class frmSmartHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parametresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portsSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.f1 = new System.Windows.Forms.Button();
            this.f3 = new System.Windows.Forms.Button();
            this.p3 = new System.Windows.Forms.Button();
            this.f2 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtDataBits = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtParity = new System.Windows.Forms.TextBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lstPorts = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1294, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parametresToolStripMenuItem
            // 
            this.parametresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portsSetupToolStripMenuItem});
            this.parametresToolStripMenuItem.Name = "parametresToolStripMenuItem";
            this.parametresToolStripMenuItem.Size = new System.Drawing.Size(151, 36);
            this.parametresToolStripMenuItem.Text = "Parametres";
            // 
            // portsSetupToolStripMenuItem
            // 
            this.portsSetupToolStripMenuItem.Name = "portsSetupToolStripMenuItem";
            this.portsSetupToolStripMenuItem.Size = new System.Drawing.Size(268, 44);
            this.portsSetupToolStripMenuItem.Text = "Ports Setup";
            this.portsSetupToolStripMenuItem.Click += new System.EventHandler(this.portsSetupToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1147, 925);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1131, 871);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Smart-Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::WinForms_POC_SmartHome.Properties.Resources.planM;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.f1);
            this.groupBox1.Controls.Add(this.f3);
            this.groupBox1.Controls.Add(this.p3);
            this.groupBox1.Controls.Add(this.f2);
            this.groupBox1.Controls.Add(this.p1);
            this.groupBox1.Controls.Add(this.p2);
            this.groupBox1.Location = new System.Drawing.Point(-8, -38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 919);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // f1
            // 
            this.f1.BackColor = System.Drawing.Color.Red;
            this.f1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.f1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.f1.ForeColor = System.Drawing.Color.White;
            this.f1.Location = new System.Drawing.Point(720, 202);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(67, 63);
            this.f1.TabIndex = 6;
            this.f1.Text = "F1";
            this.f1.UseVisualStyleBackColor = false;
            // 
            // f3
            // 
            this.f3.BackColor = System.Drawing.Color.Red;
            this.f3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.f3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.f3.ForeColor = System.Drawing.SystemColors.Control;
            this.f3.Location = new System.Drawing.Point(994, 678);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(59, 60);
            this.f3.TabIndex = 16;
            this.f3.Text = "F3";
            this.f3.UseVisualStyleBackColor = false;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.Red;
            this.p3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.p3.ForeColor = System.Drawing.SystemColors.Control;
            this.p3.Location = new System.Drawing.Point(29, 186);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(63, 60);
            this.p3.TabIndex = 14;
            this.p3.Text = "P3";
            this.p3.UseVisualStyleBackColor = false;
            // 
            // f2
            // 
            this.f2.BackColor = System.Drawing.Color.Red;
            this.f2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.f2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.f2.ForeColor = System.Drawing.SystemColors.Control;
            this.f2.Location = new System.Drawing.Point(504, 830);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(59, 60);
            this.f2.TabIndex = 8;
            this.f2.Text = "F2";
            this.f2.UseVisualStyleBackColor = false;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Red;
            this.p1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.p1.ForeColor = System.Drawing.SystemColors.Control;
            this.p1.Location = new System.Drawing.Point(178, 641);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(64, 60);
            this.p1.TabIndex = 10;
            this.p1.Text = "P1";
            this.p1.UseVisualStyleBackColor = false;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Red;
            this.p2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.p2.ForeColor = System.Drawing.SystemColors.Control;
            this.p2.Location = new System.Drawing.Point(255, 567);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(63, 60);
            this.p2.TabIndex = 12;
            this.p2.Text = "P2";
            this.p2.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cboStopBits);
            this.tabPage2.Controls.Add(this.cboParity);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.txtDataBits);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.txtParity);
            this.tabPage2.Controls.Add(this.txtBaudRate);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnOpen);
            this.tabPage2.Controls.Add(this.cboPorts);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.lstPorts);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1131, 871);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Port-Setup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Location = new System.Drawing.Point(535, 327);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(242, 40);
            this.cboStopBits.TabIndex = 29;
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(535, 208);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(242, 40);
            this.cboParity.TabIndex = 28;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(88, 327);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(417, 39);
            this.textBox8.TabIndex = 27;
            this.textBox8.Text = "stopBits  (silence entre block) : ";
            // 
            // txtDataBits
            // 
            this.txtDataBits.Location = new System.Drawing.Point(535, 269);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(242, 39);
            this.txtDataBits.TabIndex = 26;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(88, 269);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(417, 39);
            this.textBox6.TabIndex = 25;
            this.textBox6.Text = "DataBits  (nombre de byte par block) : ";
            // 
            // txtParity
            // 
            this.txtParity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParity.Enabled = false;
            this.txtParity.Location = new System.Drawing.Point(88, 208);
            this.txtParity.Name = "txtParity";
            this.txtParity.Size = new System.Drawing.Size(417, 39);
            this.txtParity.TabIndex = 24;
            this.txtParity.Text = "Parity (marge d\'erreur) : ";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(535, 147);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(242, 39);
            this.txtBaudRate.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(88, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(417, 39);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "BaudRate (byteperSecond) : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(841, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 46);
            this.button1.TabIndex = 21;
            this.button1.Text = "Fermer le Port";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Green;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpen.Location = new System.Drawing.Point(119, 397);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(200, 46);
            this.btnOpen.TabIndex = 20;
            this.btnOpen.Text = "Ouvrir le Port";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(535, 87);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(242, 40);
            this.cboPorts.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(88, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(417, 39);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "le nom du port a configurer : ";
            // 
            // lstPorts
            // 
            this.lstPorts.FormattingEnabled = true;
            this.lstPorts.ItemHeight = 32;
            this.lstPorts.Location = new System.Drawing.Point(80, 588);
            this.lstPorts.Name = "lstPorts";
            this.lstPorts.Size = new System.Drawing.Size(457, 100);
            this.lstPorts.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(80, 543);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 39);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Les Ports disponible sur cette machine :";
            // 
            // frmSmartHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1294, 1073);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSmartHome";
            this.Text = "Smart Home";
            this.Load += new System.EventHandler(this.frmSmartHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem parametresToolStripMenuItem;
        private ToolStripMenuItem portsSetupToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private Button f1;
        private Button f3;
        private Button p3;
        private Button f2;
        private Button p1;
        private Button p2;
        private TabPage tabPage2;
        private ComboBox cboStopBits;
        private ComboBox cboParity;
        private TextBox textBox8;
        private TextBox txtDataBits;
        private TextBox textBox6;
        private TextBox txtParity;
        private TextBox txtBaudRate;
        private TextBox textBox3;
        private Button button1;
        private Button btnOpen;
        private ComboBox cboPorts;
        private TextBox textBox2;
        private ListBox lstPorts;
        private TextBox textBox1;
    }
}