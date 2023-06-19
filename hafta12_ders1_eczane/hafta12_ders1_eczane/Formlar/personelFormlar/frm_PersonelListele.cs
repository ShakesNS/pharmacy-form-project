using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta12_ders1_eczane.Formlar.personelFormlar
{
    public partial class frm_PersonelListele : Form
    {


        SqlConnection cnn = new SqlConnection("Data Source=Z36-08\\SQLEXPRESS;Initial Catalog=db_eczane;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;
        public frm_PersonelListele()
        {
            InitializeComponent();
        }

        public void Goster()
        {
            lwPersonelListele.Items.Clear();

            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "  select * from tblPersonel";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["personelID"].ToString());
                item.SubItems.Add(dr["personelAdı"].ToString());
                item.SubItems.Add(dr["personelSoyadı"].ToString());
                item.SubItems.Add(dr["personelTc"].ToString());
                item.SubItems.Add(dr["personelAdres"].ToString());
                item.SubItems.Add(dr["personelSaatUcreti"].ToString());
                item.SubItems.Add(dr["personelTelefon"].ToString());
                item.SubItems.Add(dr["personelEPosta"].ToString());
                item.SubItems.Add(dr["personelIseBaslamaTarihi"].ToString());
                item.SubItems.Add(dr["personelIstenCıkmaTarihi"].ToString());
                item.SubItems.Add(dr["personelMaas"].ToString());
                item.SubItems.Add(dr["personelBankaHesapNo"].ToString());
                item.SubItems.Add(dr["personelAciklama"].ToString());



                lwPersonelListele.Items.Add(item);
            }
            cnn.Close();
            dr.Close();
        }





        private void frm_PersonelListele_Load(object sender, EventArgs e)
        {
            lwPersonelListele.Columns.Add("personelID", 150);
            lwPersonelListele.Columns.Add("personelAdı", 150);
            lwPersonelListele.Columns.Add("personelSoyadı", 200);
            lwPersonelListele.Columns.Add("personelTc", 50);
            lwPersonelListele.Columns.Add("personelAdres", 150);
            lwPersonelListele.Columns.Add("personelSaatUcreti", 50);
            lwPersonelListele.Columns.Add("personelTelefon", 50);
            lwPersonelListele.Columns.Add("personelEPosta", 80);
            lwPersonelListele.Columns.Add("personelIseBaslamaTarihi", 150);
            lwPersonelListele.Columns.Add("personelIstenCıkmaTarihi", 150);
            lwPersonelListele.Columns.Add("personelMaas", 150);
            lwPersonelListele.Columns.Add("personelBankaHesapNo", 150);
            lwPersonelListele.Columns.Add("personelAciklama", 150);

            Goster();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in lwPersonelListele.SelectedItems)
            {
                int seciliindex = Convert.ToInt32(eachItem.SubItems[0].Text);
                cnn.Open();

                cmd = cnn.CreateCommand();
                cmd.CommandText = "delete from tblPersonel where personelID=@PersonelID";


                cmd.Parameters.AddWithValue("@PersonelID", seciliindex);

                cmd.ExecuteNonQuery();
                cnn.Close();
                Goster();

                lwPersonelListele.Items.Remove(eachItem);
            }
        }


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
            
            pnlPersonelListele.Controls.Add(childForm);
            pnlPersonelListele.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem eachItem in lwPersonelListele.SelectedItems)
            {
                int index =Convert.ToInt32(eachItem.SubItems[0].Text);
                openChildForm(new Formlar.personelFormlar.frm_PersonelEkle(index));
            }
        }
    }
}
