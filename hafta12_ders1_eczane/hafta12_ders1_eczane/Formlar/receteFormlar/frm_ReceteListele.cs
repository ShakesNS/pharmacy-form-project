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

namespace hafta12_ders1_eczane.Formlar.receteFormlar
{
    public partial class frm_ReceteListele : Form
    {

        SqlConnection cnn = new SqlConnection("Data Source=Z36-08\\SQLEXPRESS;Initial Catalog=db_eczane;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;
        public frm_ReceteListele()
        {
            InitializeComponent();
        }

        public void Goster()
        {
            lwReceteListele.Items.Clear();

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



                lwReceteListele.Items.Add(item);
            }
            cnn.Close();
            dr.Close();
        }


        private void frm_ReceteListele_Load(object sender, EventArgs e)
        {

        }
    }
}
