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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        private void lnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi(); 
        private void BtnGirisYao_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_hastalar where hastatc=@p1 and hastasifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTc.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = mskTc.Text;// tc kimlik numarasını çektik
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc & Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
