namespace hafta12_ders1_eczane.Formlar.personelFormlar
{
    partial class frm_PersonelListele
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
            this.components = new System.ComponentModel.Container();
            this.lwPersonelListele = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPersonelListele = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlPersonelListele.SuspendLayout();
            this.SuspendLayout();
            // 
            // lwPersonelListele
            // 
            this.lwPersonelListele.ContextMenuStrip = this.contextMenuStrip1;
            this.lwPersonelListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwPersonelListele.FullRowSelect = true;
            this.lwPersonelListele.GridLines = true;
            this.lwPersonelListele.HideSelection = false;
            this.lwPersonelListele.Location = new System.Drawing.Point(0, 0);
            this.lwPersonelListele.Name = "lwPersonelListele";
            this.lwPersonelListele.Size = new System.Drawing.Size(800, 450);
            this.lwPersonelListele.TabIndex = 0;
            this.lwPersonelListele.UseCompatibleStateImageBehavior = false;
            this.lwPersonelListele.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // pnlPersonelListele
            // 
            this.pnlPersonelListele.Controls.Add(this.lwPersonelListele);
            this.pnlPersonelListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPersonelListele.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonelListele.Name = "pnlPersonelListele";
            this.pnlPersonelListele.Size = new System.Drawing.Size(800, 450);
            this.pnlPersonelListele.TabIndex = 2;
            // 
            // frm_PersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPersonelListele);
            this.Name = "frm_PersonelListele";
            this.Text = "frm_PersonelListele";
            this.Load += new System.EventHandler(this.frm_PersonelListele_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlPersonelListele.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwPersonelListele;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPersonelListele;
    }
}