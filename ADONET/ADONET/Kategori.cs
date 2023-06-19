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

namespace ADONET
{
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }

        private void Kategori_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=103A-10;Initial Catalog=KuzeyYeli;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select*from Kategoriler", baglan);
            baglan.Open();


            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string adi = rdr["KategoriAdi"].ToString();
                string tanimi = rdr["Tanimi"].ToString();
                listBox1.Items.Add(string.Format("{0}-{1}", adi, tanimi));
            }
            baglan.Close();
        }
    }
}

