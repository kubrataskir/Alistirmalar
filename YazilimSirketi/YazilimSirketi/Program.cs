using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSirketi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PersonelYonetim personel = new PersonelYonetim();
            personel.PersonelOlustur("Albert", "Camus", "Büro Personeli");
            personel.PersonelBilgi();

            Console.WriteLine();
            MühendisYonetim muhendis = new MühendisYonetim();
            muhendis.PersonelOlustur("Frida", "Kahlo", "Bilgisayar Mühendisi");

            muhendis.PersonelBilgi();
            muhendis.MaasEkle(24.5);

            Console.ReadLine();
        }
    }
}
