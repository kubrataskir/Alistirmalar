using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSirketi
{
    class PersonelYonetim
    {
        protected string personelAdi, personelSoyadi, personelUnvan;
        protected int personelMaas = 50000;
        private string paraDeger = "TL";
         
        public string maasBirim
        {
            get { return paraDeger; } 
            set {paraDeger = value;} 
        }
        public void PersonelOlustur(string personelAdi,string personelSoyadi,string personelUnvan)
        {
            this.personelAdi = personelAdi;
            this.personelSoyadi = personelSoyadi;
            this.personelUnvan = personelUnvan;
            if (personelMaas==0)
            {
                this.personelMaas = 15000;
            }
        }
        public void PersonelSil()
        {
            this.personelAdi = null;
            this.personelSoyadi = null;
            this.personelUnvan = null;
            this.personelMaas = 0;
            Console.WriteLine("\n-> Personel sistemden kaldırıldı.\n");
        }

        public void PersonelBilgi() 
        {
            if (personelAdi !=null && personelSoyadi !=null && personelUnvan !=null)
            {
                Console.WriteLine("Çalışanın Adı: "+personelAdi+"\n"+"Çalışanın Soyadı: "+personelSoyadi+ "\n" + "Çalışanın Unvanı: " +personelUnvan+ "\n" + "Çalışanın Maaşı: "+personelMaas );
            }
            else
            {
                Console.WriteLine("Henüz kayırlı bir kullanıcı bil");
            }
        }
    }
}
