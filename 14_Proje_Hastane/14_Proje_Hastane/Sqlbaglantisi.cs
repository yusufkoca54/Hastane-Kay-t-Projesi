using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _14_Proje_Hastane
{
    internal class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-18K9AFS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
