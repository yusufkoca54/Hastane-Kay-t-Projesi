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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string tckimlikno;
       
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tckimlikno;
           


            // sekreterin adını soyadını çekme
            SqlCommand komut = new SqlCommand("select sekreteradsoyad from tbl_sekreter where sekretertc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();


            // branşları datagriewde aktarma
            DataTable dt = new DataTable();//datatable sınıfından dt1 nesne ürettik
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_branslar",bgl.baglanti());//veri bağlayıcı
            da.Fill(dt);//data adaptarı bu veri tablosuyla doldur 
            dataGridView1.DataSource = dt;//data griewden veri kaynağınada dt den gelen değeri ekle


            // doktorları data griewde aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select (doktorad+' '+ doktorsoyad )as 'doktorlar',doktorbrans from tbl_doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            // bransları comboxa aktarma
            SqlCommand komut1 = new SqlCommand("Select bransad from tbl_branslar",bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmbbrans.Items.Add(dr1[0]).ToString();
            }
            bgl.baglanti().Close();

           
           

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            // randevu panelinde randevu kaydetme işlemi

            SqlCommand komutkaydet = new SqlCommand("insert into tbl_randevular(randevutarih,randevusaat,randevubrans,randevudoktor) values (@r1,@r2,@r3,@r4)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1",msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");

        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komutDoktorlarigetir = new SqlCommand("Select doktorad,doktorsoyad from tbl_doktorlar where doktorbrans=@p1", bgl.baglanti());
            komutDoktorlarigetir.Parameters.AddWithValue("@p1",cmbbrans.Text);
            SqlDataReader dr = komutDoktorlarigetir.ExecuteReader();
            while (dr.Read())
            {
                cmbdoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnduyuruolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_duyuru (duyuru) values (@p1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",richduyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btndoktorpanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr = new FrmDoktorPaneli();
            fr.Show();

        }

        private void btnbrans_Click(object sender, EventArgs e)
        {
            FrmBrans fr = new FrmBrans();
            fr.Show();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi fr = new FrmRandevuListesi();
            fr.Show();
        }

        private void btnguncellle_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
    }
}
 