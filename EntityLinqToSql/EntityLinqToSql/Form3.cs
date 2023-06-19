using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityLinqToSql
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //her personelin kaç kayıt yaptığını sorgulatıyoruz
            KuzeyYeliDataContext guney = new KuzeyYeliDataContext();
            var sonuc = from satis in guney.Satislars
                        join personel in guney.Personellers on
                        satis.PersonelID equals
                        personel.PersonelID
                        group satis by personel.Adi into grup
                        select new
                        {
                            PersonelAdi = grup.Key,
                            ToplamSatis = grup.Count()
                        };
            dataGridView1.DataSource = sonuc;
        }
    }
}
