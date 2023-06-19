using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSirketi
{
    internal class MühendisYonetim : PersonelYonetim
    {
        private int ilkMaas;

        public MühendisYonetim()
        {
            personelMaas = personelMaas + Convert.ToInt32(personelMaas * 3.5);
            ilkMaas = personelMaas;
            maasBirim = "$";
        }

        public void BilgiEkle()
        {
            Console.WriteLine();
            Console.WriteLine("->Zam uygulaması başarılı bir şekilde gerçekleştirildi.\n->Zam öncesi çalışan maaşı {0} {1} iken şu an {2} {3} artış ile {4} değerine ulaşmıştır.\n", ilkMaas, maasBirim, (personelMaas - ilkMaas), maasBirim, personelMaas);
        }

        public void MaasEkle(int m)
        {
            personelMaas = personelMaas + m;
            BilgiEkle();
        }
        public void MaasEkle(double m)
        {
            personelMaas = personelMaas + Convert.ToInt32(personelMaas * (m / 100));
            BilgiEkle();
        }

    }

}
