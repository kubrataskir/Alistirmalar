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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           /* KuzeyYeliDataContext dc = new KuzeyYeliDataContext();*/
            /* var sonuc = from urun in dc.Urunlers
                         join satisdetay in dc.SatisDetays on
                         urun.UrunID equals satisdetay.UrunID
                         group satisdetay by urun.UrunAdi into grup
                         select new
                         {
                             UrunAdi = grup.Key,
                             ToplamSatis = grup.Sum(x => x.Fiyat * x.Adet)
                         };

             dataGridView1.DataSource = sonuc;*/

            //lazy load = hantal yükleme yöntemi
           /* var sonuc2 = from urun in dc.Urunlers
                         select new
                         {
                             urun.UrunAdi,
                             ToplamSatis = urun.SatisDetays.
                             Any() ? urun.SatisDetays.
                             Sum(x => x.Fiyat * x.Adet) : 0//kayıt varsa yoklama alacak
                                                           // yoksa 0 verecek
                         };
            dataGridView1.DataSource = sonuc2;*/
        }
    }
}
