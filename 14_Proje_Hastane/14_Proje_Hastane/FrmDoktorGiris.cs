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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnGirisYao_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_doktorlar where doktortc=@p1 and doktorsifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.TC=mskTc.Text;
                fr.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Hatala kullanıcı adı veya şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
