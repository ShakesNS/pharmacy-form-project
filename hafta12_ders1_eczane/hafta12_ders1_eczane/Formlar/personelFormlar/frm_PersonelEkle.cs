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
    public partial class frm_PersonelEkle : Form
    {

        SqlConnection cnn = new SqlConnection("Data Source=Z36-08\\SQLEXPRESS;Initial Catalog=db_eczane;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;
        int index1;

        public frm_PersonelEkle()
        {
            InitializeComponent();
        }

        public frm_PersonelEkle(int index)
        {
            index1 = index;
            InitializeComponent();
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from tblPersonel where personelID="+index;
            //cmd.Parameters.AddWithValue("@personelID", index);
            
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //MessageBox.Show(Convert.ToString(dr["personelAdı"]));
                //string deneme=dr["personelAdı"].ToString();
                tbPersonelAd.Text = dr["personelAdı"].ToString();
                tbPersonelSoyad.Text=dr["personelSoyadı"].ToString();
                tbPersonelTC.Text=dr["personelTc"].ToString();
                tbPersonelAdres.Text=dr["personelAdres"].ToString();
                tbSaatlik.Text=dr["personelSaatUcreti"].ToString();
                tbPersonelTelefon.Text=dr["personelTelefon"].ToString();
                tbPersonelEposta.Text=dr["personelEPosta"].ToString();
                dtGiris.Value=Convert.ToDateTime(dr["personelIseBaslamaTarihi"].ToString());
                //dtCikis.Value= Convert.ToDateTime(dr["personelIstenCıkmaTarihi"].ToString());
                tbPersonelMaas.Text=dr["personelMaas"].ToString();
                tbPersonelHesapNo.Text=dr["personelBankaHesapNo"].ToString();
                tbAciklama.Text = dr["personelAciklama"].ToString();

                //InitializeComponent();


            }
            cnn.Close();

            btnEkle.Visible = false;
            btnGuncelle.Visible = true;
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmd=cnn.CreateCommand();
            cmd.CommandText = "sp_PersonelINSERT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("personelAdı", tbPersonelAd.Text);
            cmd.Parameters.AddWithValue("@personelSoyadı", tbPersonelSoyad.Text);
            cmd.Parameters.AddWithValue("@personelTc", tbPersonelTC.Text);
            cmd.Parameters.AddWithValue("@personelAdres", tbPersonelAdres.Text);
            cmd.Parameters.AddWithValue("@personelSaatUcreti", tbSaatlik.Text != String.Empty ? Convert.ToDecimal(tbSaatlik.Text) : (Decimal?)null);
            cmd.Parameters.AddWithValue("@personelTelefon", tbPersonelTelefon.Text);
            cmd.Parameters.AddWithValue("@personelEPosta", tbPersonelEposta.Text);
            cmd.Parameters.AddWithValue("@personelIseBaslamaTarihi", dtGiris.Value);
            cmd.Parameters.AddWithValue("@personelIstenCıkmaTarihi", dtCikis.Value);
            cmd.Parameters.AddWithValue("@personelMaas", tbPersonelMaas.Text != String.Empty ? Convert.ToDecimal(tbPersonelMaas.Text) : (Decimal?)null);
            cmd.Parameters.AddWithValue("@personelBankaHesapNo", tbPersonelHesapNo.Text);
            cmd.Parameters.AddWithValue("@personelAciklama", tbAciklama.Text);
            


            cmd.ExecuteNonQuery(); 
            cnn.Close();
            


        }




        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "sp_PersonelUPDATE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@personelID", index1);
            cmd.Parameters.AddWithValue("personelAdı", tbPersonelAd.Text);
            cmd.Parameters.AddWithValue("@personelSoyadı", tbPersonelSoyad.Text);
            cmd.Parameters.AddWithValue("@personelTc", tbPersonelTC.Text);
            cmd.Parameters.AddWithValue("@personelAdres", tbPersonelAdres.Text);
            cmd.Parameters.AddWithValue("@personelSaatUcreti", tbSaatlik.Text != String.Empty ? Convert.ToDecimal(tbSaatlik.Text) : (Decimal?)null);
            cmd.Parameters.AddWithValue("@personelTelefon", tbPersonelTelefon.Text);
            cmd.Parameters.AddWithValue("@personelEPosta", tbPersonelEposta.Text);
            cmd.Parameters.AddWithValue("@personelIseBaslamaTarihi", dtGiris.Value);
            cmd.Parameters.AddWithValue("@personelIstenCıkmaTarihi", dtCikis.Value);
            cmd.Parameters.AddWithValue("@personelMaas", tbPersonelMaas.Text != String.Empty ? Convert.ToDecimal(tbPersonelMaas.Text) : (Decimal?)null);
            cmd.Parameters.AddWithValue("@personelBankaHesapNo", tbPersonelHesapNo.Text);
            cmd.Parameters.AddWithValue("@personelAciklama", tbAciklama.Text);



            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
