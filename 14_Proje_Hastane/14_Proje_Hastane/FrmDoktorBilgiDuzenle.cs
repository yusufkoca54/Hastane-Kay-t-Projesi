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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string tcnoo;
        private void DoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTc.Text = tcnoo;

            // bilgi düzenle formuna gittiğimizde doktor bilgilerini görmüş oldu bu aşağıda yazdığımız kodlar
            SqlCommand komut = new SqlCommand("select * from tbl_doktorlar where doktortc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                cmbbrans.Text = dr[3].ToString();
                txtsifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();


            // doktor bilgi güncelleme formunda doktorun branş seçeneklerini getirmiş olduk

            SqlCommand komut1 = new SqlCommand("select bransad from tbl_branslar",bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                cmbbrans.Items.Add(dr1[0]).ToString();
            }
            bgl.baglanti().Close();
           
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_doktorlar set doktorad=@p1,doktorsoyad=@p2,doktorbrans=@p3,doktorsifre=@p4 where doktortc=@p5",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut.Parameters.AddWithValue("@p5", mskTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşmiştir","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
