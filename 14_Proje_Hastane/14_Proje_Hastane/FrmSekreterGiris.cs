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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void BtnGirisYao_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_sekreter where sekretertc=@p1 and sekretersifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay fr = new FrmSekreterDetay();
                fr.tckimlikno = mskTc.Text; // sekreterin tc sini giriş ekranına yazdırma
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanliş Şifre Girdiniz.", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();

        }
    }
}
