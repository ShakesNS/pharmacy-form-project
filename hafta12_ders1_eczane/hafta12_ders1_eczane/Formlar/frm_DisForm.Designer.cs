namespace hafta12_ders1_eczane.Formlar
{
    partial class frm_DisForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.ilaçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniReçeteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geçmişReçeteListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Ana = new System.Windows.Forms.Panel();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilaçlarToolStripMenuItem,
            this.personellerToolStripMenuItem,
            this.reçeteToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1436, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // ilaçlarToolStripMenuItem
            // 
            this.ilaçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeleToolStripMenuItem});
            this.ilaçlarToolStripMenuItem.Name = "ilaçlarToolStripMenuItem";
            this.ilaçlarToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ilaçlarToolStripMenuItem.Text = "İlaçlar";
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.listeleToolStripMenuItem.Text = "İlaç Listele";
            this.listeleToolStripMenuItem.Click += new System.EventHandler(this.listeleToolStripMenuItem_Click);
            // 
            // personellerToolStripMenuItem
            // 
            this.personellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem,
            this.listeleToolStripMenuItem1});
            this.personellerToolStripMenuItem.Name = "personellerToolStripMenuItem";
            this.personellerToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.personellerToolStripMenuItem.Text = "Personeller";
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            this.yeniKayıtToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtToolStripMenuItem_Click);
            // 
            // listeleToolStripMenuItem1
            // 
            this.listeleToolStripMenuItem1.Name = "listeleToolStripMenuItem1";
            this.listeleToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.listeleToolStripMenuItem1.Text = "Personel Listele";
            this.listeleToolStripMenuItem1.Click += new System.EventHandler(this.listeleToolStripMenuItem1_Click);
            // 
            // reçeteToolStripMenuItem
            // 
            this.reçeteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniReçeteToolStripMenuItem,
            this.geçmişReçeteListeleToolStripMenuItem});
            this.reçeteToolStripMenuItem.Name = "reçeteToolStripMenuItem";
            this.reçeteToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reçeteToolStripMenuItem.Text = "Reçete";
            // 
            // yeniReçeteToolStripMenuItem
            // 
            this.yeniReçeteToolStripMenuItem.Name = "yeniReçeteToolStripMenuItem";
            this.yeniReçeteToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.yeniReçeteToolStripMenuItem.Text = "Yeni Reçete";
            this.yeniReçeteToolStripMenuItem.Click += new System.EventHandler(this.yeniReçeteToolStripMenuItem_Click);
            // 
            // geçmişReçeteListeleToolStripMenuItem
            // 
            this.geçmişReçeteListeleToolStripMenuItem.Name = "geçmişReçeteListeleToolStripMenuItem";
            this.geçmişReçeteListeleToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.geçmişReçeteListeleToolStripMenuItem.Text = "Geçmiş Reçete Listele";
            this.geçmişReçeteListeleToolStripMenuItem.Click += new System.EventHandler(this.geçmişReçeteListeleToolStripMenuItem_Click);
            // 
            // pnl_Ana
            // 
            this.pnl_Ana.AutoScroll = true;
            this.pnl_Ana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Ana.Location = new System.Drawing.Point(0, 24);
            this.pnl_Ana.Name = "pnl_Ana";
            this.pnl_Ana.Size = new System.Drawing.Size(1436, 603);
            this.pnl_Ana.TabIndex = 1;
            // 
            // frm_DisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1436, 627);
            this.Controls.Add(this.pnl_Ana);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "frm_DisForm";
            this.Text = "frm_DisForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem ilaçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Ana;
        private System.Windows.Forms.ToolStripMenuItem personellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reçeteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniReçeteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geçmişReçeteListeleToolStripMenuItem;
    }
}