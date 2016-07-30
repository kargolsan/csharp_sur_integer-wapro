namespace SUR_Integer_WAPRO.Modules.ContainerMDI.Views
{
    partial class MDIView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIView));
            this.footer = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.footerDatabaseInformation = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindowAuthenticate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContractors = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArticles = new System.Windows.Forms.ToolStripMenuItem();
            this.footer.SuspendLayout();
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.footerDatabaseInformation});
            this.footer.Location = new System.Drawing.Point(0, 593);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1271, 22);
            this.footer.TabIndex = 1;
            this.footer.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(143, 17);
            this.toolStripStatusLabel1.Text = "Połączenie z bazą danych:";
            // 
            // footerDatabaseInformation
            // 
            this.footerDatabaseInformation.ForeColor = System.Drawing.SystemColors.GrayText;
            this.footerDatabaseInformation.Name = "footerDatabaseInformation";
            this.footerDatabaseInformation.Size = new System.Drawing.Size(89, 17);
            this.footerDatabaseInformation.Text = "Brak połączenia";
            // 
            // menuTop
            // 
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.menuContractors,
            this.menuArticles});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(1271, 24);
            this.menuTop.TabIndex = 2;
            this.menuTop.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWindowAuthenticate,
            this.menuLogout});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // menuWindowAuthenticate
            // 
            this.menuWindowAuthenticate.Name = "menuWindowAuthenticate";
            this.menuWindowAuthenticate.Size = new System.Drawing.Size(161, 22);
            this.menuWindowAuthenticate.Text = "Okno logowania";
            this.menuWindowAuthenticate.Click += new System.EventHandler(this.menuWindowAuthenticate_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Enabled = false;
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(161, 22);
            this.menuLogout.Text = "Wylogowanie";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // menuContractors
            // 
            this.menuContractors.Enabled = false;
            this.menuContractors.Name = "menuContractors";
            this.menuContractors.Size = new System.Drawing.Size(83, 20);
            this.menuContractors.Text = "Kontrahenci";
            this.menuContractors.Click += new System.EventHandler(this.menuContractors_Click);
            // 
            // menuArticles
            // 
            this.menuArticles.Enabled = false;
            this.menuArticles.Name = "menuArticles";
            this.menuArticles.Size = new System.Drawing.Size(63, 20);
            this.menuArticles.Text = "Artykuły";
            this.menuArticles.Click += new System.EventHandler(this.menuArticles_Click);
            // 
            // MDIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 615);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.menuTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuTop;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MDIView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = string.Format("SUR Integer WAPRO - v.{0}", System.Windows.Forms.Application.ProductVersion);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MDIView_Shown);
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip footer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel footerDatabaseInformation;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menuWindowAuthenticate;
        public System.Windows.Forms.MenuStrip menuTop;
        public System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuContractors;
        private System.Windows.Forms.ToolStripMenuItem menuArticles;
    }
}