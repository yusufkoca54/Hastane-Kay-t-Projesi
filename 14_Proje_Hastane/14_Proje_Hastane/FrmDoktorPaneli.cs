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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // BranŞLARI COMBA BOXA AKTARMA
            SqlCommand komut = new SqlCommand("select bransad from tbl_branslar", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbbrans.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_doktorlar (doktorad,doktorsoyad,doktorbrans,doktortc,doktorsifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p4", msktc.Text);
            komut.Parameters.AddWithValue("@p5", txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ekleme İşlemi Başarıyla Gerçekleşmiştir", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // doktor panelinde işaretlediğimiz satırları sol tarafa yazdırdık
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msktc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_doktorlar where doktortc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçeklemiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_doktorlar set doktorad=@p1,doktorsoyad=@p2,doktorbrans=@p3,doktorsifre=@p4 where doktortc=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p5", msktc.Text);
            komut.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşmiştir", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select bransad from tbl_branslar", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbbrans.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();
        }
    }
}
