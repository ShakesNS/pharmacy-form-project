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

namespace hafta12_ders1_eczane.Formlar.IlacFormlar
{
    public partial class frm_IlacListele : Form
    {
        SqlConnection cnn = new SqlConnection("Data Source=Z36-08\\SQLEXPRESS;Initial Catalog=db_eczane;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;



        public frm_IlacListele()
        {
            InitializeComponent();
        }

        public void Goster()
        {
            lwIlacListele.Items.Clear();




            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "  select * from vw_IlaclarGoster";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["ilacID"].ToString());
                item.SubItems.Add(dr["ilacBarkod"].ToString());
                item.SubItems.Add(dr["ilacAd"].ToString());
                item.SubItems.Add(dr["ilacFiyat"].ToString());
                item.SubItems.Add(dr["FirmaAd"].ToString());
                item.SubItems.Add(dr["ilacKDVOran"].ToString());
                item.SubItems.Add(dr["ilacStokAdet"].ToString());
                item.SubItems.Add(dr["turAdi"].ToString());
                item.SubItems.Add(dr["ilacReceteliMi"].ToString());
                item.SubItems.Add(dr["ilacAcıklama"].ToString());
                item.SubItems.Add(dr["depoAdı"].ToString());



                lwIlacListele.Items.Add(item);
            }
            cnn.Close();
        }

        private void frm_IlacListele_Load(object sender, EventArgs e)
        {
            lwIlacListele.Columns.Add("ilacID", 150);
            lwIlacListele.Columns.Add("ilacBarkod", 150);
            lwIlacListele.Columns.Add("ilacAd", 200);
            lwIlacListele.Columns.Add("ilacFiyat", 50);
            lwIlacListele.Columns.Add("UreticiFirmaID", 150);
            lwIlacListele.Columns.Add("ilacKDVOran", 50);
            lwIlacListele.Columns.Add("ilacStokAdet", 50);
            lwIlacListele.Columns.Add("TurID", 80);
            lwIlacListele.Columns.Add("ilacReceteliMi", 150);
            lwIlacListele.Columns.Add("ilacAcıklama", 150);
            lwIlacListele.Columns.Add("ilacDepoFirma", 150);

            Goster();
        }
    }
}
