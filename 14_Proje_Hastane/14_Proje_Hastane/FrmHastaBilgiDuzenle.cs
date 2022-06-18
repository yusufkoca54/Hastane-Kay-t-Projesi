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
    public partial class FrmHastaBilgiDuzenle : Form
    {
        public FrmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TCno; // bilgi düzenleme sayfasına tc yi yazdırmak için erişim belirleyici olarak public string tc no yaptık
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTc.Text = TCno;
            SqlCommand komut1 = new SqlCommand("select * from tbl_hastalar where hastatc=@p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",mskTc.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            while(dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                msktel.Text = dr[4].ToString();
                txtsifre.Text=dr[5].ToString();
                cmbcinsiyet.Text = dr[6].ToString();

            }
            bgl.baglanti().Close();
            


        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update tbl_hastalar set hastanead=@p1,hastanesoyad=@p2,hastatelefon=@p3,hastasifre=@p4,hastacinsiyet=@p5 where hastatc=@p6",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtad.Text);
            komut2.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", msktel.Text);
            komut2.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbcinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", mskTc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşmiştir","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
