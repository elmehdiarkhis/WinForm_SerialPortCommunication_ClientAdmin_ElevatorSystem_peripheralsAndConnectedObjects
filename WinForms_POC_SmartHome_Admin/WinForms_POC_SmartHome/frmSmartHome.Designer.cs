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
            this.pct = new System.Windows.Forms.PictureBox();
            this.f1 = new System.Windows.Forms.Button();
            this.txtHistorique = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnF2 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Button();
            this.p3 = new System.Windows.Forms.Button();
            this.f3 = new System.Windows.Forms.Button();
            this.portSetup_uc1 = new WinForms_POC_SmartHome.portSetup_UC();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1449, 40);
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
            // pct
            // 
            this.pct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pct.Image = global::WinForms_POC_SmartHome.Properties.Resources.planM;
            this.pct.Location = new System.Drawing.Point(0, 40);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(1449, 727);
            this.pct.TabIndex = 4;
            this.pct.TabStop = false;
            this.pct.Click += new System.EventHandler(this.pct_Click);
            // 
            // f1
            // 
            this.f1.BackColor = System.Drawing.Color.Red;
            this.f1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.f1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.f1.ForeColor = System.Drawing.Color.White;
            this.f1.Location = new System.Drawing.Point(523, 198);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(50, 46);
            this.f1.TabIndex = 6;
            this.f1.Text = "F1";
            this.f1.UseVisualStyleBackColor = false;
            this.f1.Click += new System.EventHandler(this.f1_Click);
            // 
            // txtHistorique
            // 
            this.txtHistorique.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtHistorique.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHistorique.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHistorique.ForeColor = System.Drawing.SystemColors.Window;
            this.txtHistorique.Location = new System.Drawing.Point(851, 497);
            this.txtHistorique.Multiline = true;
            this.txtHistorique.Name = "txtHistorique";
            this.txtHistorique.ReadOnly = true;
            this.txtHistorique.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorique.Size = new System.Drawing.Size(598, 270);
            this.txtHistorique.TabIndex = 8;
            this.txtHistorique.Text = "Historique de Detection :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1333, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 46);
            this.button1.TabIndex = 19;
            this.button1.Text = "Fermer le Port";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Green;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpen.Location = new System.Drawing.Point(860, 363);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(101, 46);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.Text = "Ouvrir le Port";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnF2
            // 
            this.btnF2.BackColor = System.Drawing.Color.Red;
            this.btnF2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnF2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnF2.ForeColor = System.Drawing.Color.White;
            this.btnF2.Location = new System.Drawing.Point(362, 696);
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(50, 46);
            this.btnF2.TabIndex = 29;
            this.btnF2.Text = "F2";
            this.btnF2.UseVisualStyleBackColor = false;
            this.btnF2.Click += new System.EventHandler(this.btnF2_Click);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Red;
            this.p1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.p1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p1.Location = new System.Drawing.Point(86, 545);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(62, 53);
            this.p1.TabIndex = 33;
            this.p1.Text = "P1";
            this.p1.UseVisualStyleBackColor = false;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Red;
            this.p2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.p2.ForeColor = System.Drawing.Color.White;
            this.p2.Location = new System.Drawing.Point(160, 487);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(50, 46);
            this.p2.TabIndex = 35;
            this.p2.Text = "P2";
            this.p2.UseVisualStyleBackColor = false;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.Red;
            this.p3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.p3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.p3.ForeColor = System.Drawing.Color.White;
            this.p3.Location = new System.Drawing.Point(39, 210);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(50, 46);
            this.p3.TabIndex = 37;
            this.p3.Text = "P3";
            this.p3.UseVisualStyleBackColor = false;
            // 
            // f3
            // 
            this.f3.BackColor = System.Drawing.Color.Red;
            this.f3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.f3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.f3.ForeColor = System.Drawing.Color.White;
            this.f3.Location = new System.Drawing.Point(738, 574);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(50, 46);
            this.f3.TabIndex = 39;
            this.f3.Text = "F3";
            this.f3.UseVisualStyleBackColor = false;
            // 
            // portSetup_uc1
            // 
            this.portSetup_uc1.Location = new System.Drawing.Point(851, 40);
            this.portSetup_uc1.Name = "portSetup_uc1";
            this.portSetup_uc1.Size = new System.Drawing.Size(485, 317);
            this.portSetup_uc1.TabIndex = 41;
            // 
            // frmSmartHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1449, 767);
            this.Controls.Add(this.portSetup_uc1);
            this.Controls.Add(this.f3);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.btnF2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtHistorique);
            this.Controls.Add(this.f1);
            this.Controls.Add(this.pct);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSmartHome";
            this.Text = "Smart Home";
            this.Load += new System.EventHandler(this.frmSmartHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem parametresToolStripMenuItem;
        private ToolStripMenuItem portsSetupToolStripMenuItem;
        private PictureBox pct;
        private Button f1;
        private TextBox txtHistorique;
        private Button button1;
        private Button btnOpen;
        private Button btnF2;
        private Button p1;
        private Button p2;
        private Button p3;
        private Button f3;
        private portSetup_UC portSetup_uc1;
    }
}