using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta12_ders1_eczane.Formlar
{
    public partial class frm_DisForm : Form
    {
        public frm_DisForm()
        {
            InitializeComponent();
        }

        public frm_DisForm(int index)
        {

        }



        //Formlar.IlacFormlar.frm_IlacListele IlacListele;

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Ana.Controls.Add(childForm);
            pnl_Ana.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Formlar.IlacFormlar.frm_IlacListele());
            //Formlar.IlacFormlar.frm_IlacListele
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Formlar.personelFormlar.frm_PersonelEkle());
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new Formlar.personelFormlar.frm_PersonelListele());
        }

        private void yeniReçeteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Formlar.receteFormlar.frm_ReceteEkle());
        }

        private void geçmişReçeteListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Formlar.receteFormlar.frm_ReceteListele());
        }
    }
}
