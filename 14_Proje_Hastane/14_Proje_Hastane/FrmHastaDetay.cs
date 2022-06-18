using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _14_Proje_Hastane
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;

            // ad soyad çekme
            SqlCommand komut = new SqlCommand("select hastanead,hastanesoyad from tbl_hastalar where hastatc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();


            //randevu geçmişi


            DataTable dt = new DataTable();// veri tablosu
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where hastatc="+tc,bgl.baglanti());// dadadapter bizim verilere aktarmak için kullandığımız komutumuzdur
            da.Fill(dt);// data adaptarın içini doldur neyle tablodan gelecek olan değerler
            dataGridView1.DataSource = dt;


            // branşları çekme

            SqlCommand komut2 = new SqlCommand("select bransad from tbl_branslar",bgl.baglanti());
             SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


            
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad From tbl_doktorlar where doktorbrans=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where randevubrans='" + cmbbrans.Text + "'"+ " and RandevuDoktor = '" + cmbdoktor.Text + "'and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void lnkbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDuzenle fr = new FrmHastaBilgiDuzenle();
            fr.TCno = lbltc.Text;// bilgi düzenle formunu açtığımızda direk sayfaya tc yi yazdırdık 
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            
        }

        private void btnrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevular set randevudurum=1,hastatc=@p1,hastasikayet=@p2 where randevuid=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            komut.Parameters.AddWithValue("@p2", richsikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
