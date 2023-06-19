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
    public partial class frm_ReceteEkle : Form
    {

        SqlConnection cnn = new SqlConnection("Data Source=Z36-08\\SQLEXPRESS;Initial Catalog=db_eczane;Integrated Security=True");
        //SqlConnection cnn = new SqlConnection("Data Source=DIMEC-DESKTOP;Initial Catalog=db_eczane;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;

        public frm_ReceteEkle()
        {
            InitializeComponent();
        }

        private void btnMusteriKontrol_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmd=cnn.CreateCommand();
            cmd.CommandText = "select * from tblMusteriler where musteriTc=@musteriTC";
            cmd.Parameters.AddWithValue("@musteriTC", lblMusteriTC.Text);
            dr=cmd.ExecuteReader();
            if(dr.HasRows)
            {
                while (dr.Read())
                {
                    tbMusteriTC.Text=dr["musteriTc"].ToString();
                    tbMusteriAd.Text=dr["musteriAdı"].ToString();
                    tbMusteriSoyad.Text= dr["musteriSoyadı"].ToString();
                    tbMusteriAdres.Text= dr["musteriAdres"].ToString();                 
                    tbMusteriTelefon.Text= dr["musteriTelefon"].ToString();
                    tbMusteriEposta.Text= dr["MusteriEPosta"].ToString();


                }
                tbMusteriTC.Enabled=false;
                tbMusteriAd.Enabled = false;
                tbMusteriSoyad.Enabled = false;
                tbMusteriAdres.Enabled = false;
                tbMusteriTelefon.Enabled = false;
                tbMusteriEposta.Enabled = false;
                btnGuncelle1.Visible = true;
                pnlMusteriGuncelle.Visible = true;

            }
            else
            {
                MessageBox.Show("böyle bir müşteri yok");
            }
            cnn.Close();
        }

        private void btnGuncelle1_Click(object sender, EventArgs e)
        {
            btnGuncelle2.Visible = true;
            


            tbMusteriTC.Enabled = true;
            tbMusteriAd.Enabled = true;
            tbMusteriSoyad.Enabled = true;
            tbMusteriAdres.Enabled = true;
            tbMusteriTelefon.Enabled = true;
            tbMusteriEposta.Enabled = true;

            btnGuncelle1.Visible = false;

            

        }

        private void btnGuncelle2_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "sp_MusteriUPDATE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@musteriAdı", tbMusteriAd.Text);
            cmd.Parameters.AddWithValue("@musteriSoyadı ", tbMusteriSoyad.Text);
            cmd.Parameters.AddWithValue("@musteriTc", tbMusteriTC.Text);
            cmd.Parameters.AddWithValue("@musteriAdres", tbMusteriAdres.Text);
            cmd.Parameters.AddWithValue("@musteriTelefon", tbMusteriTelefon.Text);
            cmd.Parameters.AddWithValue("@MusteriEPosta", tbMusteriEposta.Text);
            cmd.ExecuteNonQuery();

            cnn.Close();

            MessageBox.Show("güncellendi");

            pnlMusteriGuncelle.Visible = false;
        }
        int receteID;
        private void btnGiris_Click(object sender, EventArgs e)
        {


            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select receteID from tblReceteler where receteNo=@ReceteNo ";
            cmd.Parameters.AddWithValue("@ReceteNo", tbReceteNumarasi.Text);
            receteID=Convert.ToInt32(cmd.ExecuteScalar());
            cnn.Close();


            cnn.Open();
            cmd=cnn.CreateCommand();
            cmd.CommandText = "sp_ReceteNoGoreMusteri ";
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@receteNo", tbReceteNumarasi.Text);
            dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                lblReceteNo.Text = dr["receteNo"].ToString();
                lblMusteriTC.Text = dr["musteriTc"].ToString();
                lblMusteriAd.Text = dr["musteriAdı"].ToString();
                lblMusteriSoyad.Text = dr["musteriSoyadı"].ToString();
                lblDoktorAd.Text = dr["receteDoktor"].ToString();
                lblReceteTarihi.Text = dr["receteTarih"].ToString();
                lblReceteTutar.Text = dr["receteTutar"].ToString();

            }
            cnn.Close();
            dr.Close();
            pnlIlacAra.Visible = true;
            pnlIlacListesi.Visible = true;




            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "sp_ReceteIlacListesi ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@receteNo", tbReceteNumarasi.Text);
            dr = cmd.ExecuteReader();
            decimal recetetutar=0;
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["ilacID"].ToString());
                item.SubItems.Add(dr["ilacBarkod"].ToString());
                item.SubItems.Add(dr["ilacAd"].ToString());
                item.SubItems.Add(dr["ilacAdet"].ToString());
                item.SubItems.Add(dr["ilacFiyat"].ToString());               
                recetetutar+= Convert.ToDecimal(dr["ilacFiyat"].ToString()) * Convert.ToDecimal(dr["ilacAdet"].ToString());
                
                item.SubItems.Add(dr["ilacKDVOran"].ToString());
                
                

                lwIlacListesi.Items.Add(item);
            }
            lblReceteTutar.Text += recetetutar.ToString();
            cnn.Close();
            dr.Close();

            
            lwIlacAra.Items.Clear();




            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "  select * from vw_IlaclarGoster where ilacAd like '%'+@ilacara+'%' ";
            cmd.Parameters.AddWithValue("@ilacara", tbIlacAra.Text);
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



                lwIlacAra.Items.Add(item);
            }
            cnn.Close();



            cbHarfler.Items.Add("A");
            cbHarfler.Items.Add("B");
            cbHarfler.Items.Add("C");
            cbHarfler.Items.Add("D");





        }

        private void frm_ReceteEkle_Load(object sender, EventArgs e)
        {
            lwIlacListesi.Columns.Add("ilacID", 50);
            lwIlacListesi.Columns.Add("ilacBarkod", 150);
            lwIlacListesi.Columns.Add("ilacAd", 200);
            lwIlacListesi.Columns.Add("ilacAdet", 50);
            lwIlacListesi.Columns.Add("ilacFiyat", 70);
            lwIlacListesi.Columns.Add("ilacKDVOran", 80);


            lwIlacAra.Columns.Add("ilacID", 150);
            lwIlacAra.Columns.Add("ilacBarkod", 150);
            lwIlacAra.Columns.Add("ilacAd", 200);
            lwIlacAra.Columns.Add("ilacFiyat", 50);
            lwIlacAra.Columns.Add("UreticiFirmaID", 150);
            lwIlacAra.Columns.Add("ilacKDVOran", 50);
            lwIlacAra.Columns.Add("ilacStokAdet", 50);
            lwIlacAra.Columns.Add("TurID", 80);
            lwIlacAra.Columns.Add("ilacReceteliMi", 150);
            lwIlacAra.Columns.Add("ilacAcıklama", 150);
            lwIlacAra.Columns.Add("ilacDepoFirma", 150);





        }

        private void tbIlacAra_TextChanged(object sender, EventArgs e)
        {
            lwIlacAra.Items.Clear();




            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "  select * from vw_IlaclarGoster where ilacAd like '%'+@ilacara+'%' ";
            cmd.Parameters.AddWithValue("@ilacara", tbIlacAra.Text);
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



                lwIlacAra.Items.Add(item);
            }
            cnn.Close();
        }



        private void btnAraA_Click(object sender, EventArgs e)
        {
            lwIlacAra.Items.Clear();

            Button deger=(Button)sender;


            foreach (Control item2 in pnlIlacAra.Controls)
            {

                if (item2.GetType() == typeof(Button))
                {
                    string harf = item2.Text;
                    cnn.Open();
                    cmd = cnn.CreateCommand();
                    cmd.CommandText = "select * from vw_IlaclarGoster where ilacAd like @ilacara+'%'  ";
                    cmd.Parameters.AddWithValue("@ilacara", deger.Tag);
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



                        lwIlacAra.Items.Add(item);
                    }
                    cnn.Close();
                }
            }
        }

        private void cbHarfler_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "select * from vw_IlaclarGoster where ilacAd like @ilacara+'%'  ";
            cmd.Parameters.AddWithValue("@ilacara", cbHarfler.SelectedText);
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



                lwIlacAra.Items.Add(item);
            }
            cnn.Close();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string seciliIndex;


            foreach (ListViewItem eachItem in lwIlacAra.SelectedItems)
            {
                seciliIndex = eachItem.SubItems[0].Text.ToString();

                SqlConnection cnn1 = new SqlConnection("Data Source=Z36-08\\SQLEXPRESS;Initial Catalog=db_eczane;Integrated Security=True");
                //SqlConnection cnn1 = new SqlConnection("Data Source=DIMEC-DESKTOP;Initial Catalog=db_eczane;Integrated Security=True");
                cnn1.Open();
                cmd = cnn1.CreateCommand();
                cmd.CommandText = "sp_ReceteIlacIDListesi ";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@receteNo", receteID);
                dr = cmd.ExecuteReader();


                string[] IDs= new string[lwIlacListesi.Items.Count];

                for (int i = 0; i < IDs.Length;)
                {

                    while (dr.Read())
                    {

                        IDs[i] = dr["ilacID"].ToString();
                        i++;
                        
                    }


                }


                int kontrol=0;


                if(kontrol==0)
                {
                    foreach (string item in IDs)
                    {
                        if (seciliIndex == item)
                        {
                            //MessageBox.Show(dr["ilacID"].ToString());

                            cnn.Open();
                            cmd = cnn.CreateCommand();
                            cmd.CommandText = "update tblialcRecete set ilacAdet=ilacAdet+1 where receteID=@ReceteID and ilacID=@ilacID ";
                            cmd.Parameters.AddWithValue("@ReceteID", receteID);
                            cmd.Parameters.AddWithValue("@ilacID", Convert.ToInt32(item));
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                            kontrol = 1;
                            break;
                        }
                        else if(seciliIndex!=item)
                        {
                            kontrol = 3;
                        }

                    }
                    

                }
                if (kontrol == 3)
                {
                
                    cnn.Close();
                    cnn.Open();
                    cmd = cnn.CreateCommand();
                    cmd.CommandText = "sp_ilacReceteInsert ";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ilacID", Convert.ToInt32(seciliIndex));
                    cmd.Parameters.AddWithValue("@receteID", receteID);
                    cmd.Parameters.AddWithValue("@ilacAdet", 1);

                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }








                cnn1.Close();
                //dr.Close();




            }

            receteilacGoster();





        }


        public void receteilacGoster()
        {
            lwIlacListesi.Items.Clear();
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandText = "sp_ReceteIlacListesi ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@receteNo", tbReceteNumarasi.Text);
            dr = cmd.ExecuteReader();
            decimal recetetutar = 0;
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["ilacID"].ToString());
                item.SubItems.Add(dr["ilacBarkod"].ToString());
                item.SubItems.Add(dr["ilacAd"].ToString());
                item.SubItems.Add(dr["ilacAdet"].ToString());
                item.SubItems.Add(dr["ilacFiyat"].ToString());
                //recetetutar+= Convert.ToDecimal(dr["ilacFiyat"].ToString()) * Convert.ToDecimal(dr["ilacAdet"].ToString());

                item.SubItems.Add(dr["ilacKDVOran"].ToString());



                lwIlacListesi.Items.Add(item);
            }
            lblReceteTutar.Text += recetetutar.ToString();
            cnn.Close();
            dr.Close();
        }
    }
}
