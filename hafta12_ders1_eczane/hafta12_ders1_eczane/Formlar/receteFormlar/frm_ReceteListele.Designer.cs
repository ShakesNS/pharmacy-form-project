namespace hafta12_ders1_eczane.Formlar.receteFormlar
{
    partial class frm_ReceteListele
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lwReceteListele = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lwReceteListele);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // lwReceteListele
            // 
            this.lwReceteListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwReceteListele.FullRowSelect = true;
            this.lwReceteListele.HideSelection = false;
            this.lwReceteListele.Location = new System.Drawing.Point(0, 0);
            this.lwReceteListele.Name = "lwReceteListele";
            this.lwReceteListele.Size = new System.Drawing.Size(800, 450);
            this.lwReceteListele.TabIndex = 0;
            this.lwReceteListele.UseCompatibleStateImageBehavior = false;
            this.lwReceteListele.View = System.Windows.Forms.View.Details;
            // 
            // frm_ReceteListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frm_ReceteListele";
            this.Text = "frm_ReceteListele";
            this.Load += new System.EventHandler(this.frm_ReceteListele_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lwReceteListele;
    }
}