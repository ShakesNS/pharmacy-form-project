namespace hafta12_ders1_eczane.Formlar.IlacFormlar
{
    partial class frm_IlacListele
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
            this.lwIlacListele = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lwIlacListele
            // 
            this.lwIlacListele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwIlacListele.HideSelection = false;
            this.lwIlacListele.Location = new System.Drawing.Point(0, 0);
            this.lwIlacListele.Name = "lwIlacListele";
            this.lwIlacListele.Size = new System.Drawing.Size(857, 498);
            this.lwIlacListele.TabIndex = 0;
            this.lwIlacListele.UseCompatibleStateImageBehavior = false;
            this.lwIlacListele.View = System.Windows.Forms.View.Details;
            // 
            // frm_IlacListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 498);
            this.Controls.Add(this.lwIlacListele);
            this.Name = "frm_IlacListele";
            this.Text = "frm_IlacListele";
            this.Load += new System.EventHandler(this.frm_IlacListele_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwIlacListele;
    }
}