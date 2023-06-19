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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategori ktgr = new Kategori();
            ktgr.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection();
            baglan.ConnectionString = ("Data Source=103A-10;Initial Catalog=KuzeyYeli;Integrated Security=True");

            SqlCommand kmt = new SqlCommand();
            kmt.CommandText = "select*from Urunler";
            kmt.Connection = baglan;
            baglan.Open();


            SqlDataReader readr = kmt.ExecuteReader();
            while (readr.Read())
            {
                string isim = readr["UrunAdi"].ToString();
                string fiyat = readr["Fiyat"].ToString();
                string stok = readr["Stok"].ToString();
               UrunlerListesi.Items.Add(string.Format("{0}-{1}-{2}", isim, fiyat,stok));
            }
            baglan.Close();
        }
    }
}
