using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketbolSuperLig
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Basketbolcu kobe= new Basketbolcu();
            kobe.ULKE = "Amerika";
            kobe.LIG = "NBA";
            kobe.TAKIM = "Los Angeles Lakers";
            kobe.AD = "Kobe";
            kobe.SOYAD = "Bryant";
            kobe.POZİSYON = "Şutör gard";//kısa forvert
            kobe.YAS = 41;


            Console.WriteLine("AD: "+kobe.AD);
            Console.WriteLine("SOYAD: "+kobe.SOYAD);
            Console.WriteLine("YAŞ: "+kobe.YAS);
            Console.WriteLine("ÜLKE: "+kobe.ULKE);
            Console.WriteLine("LİG: "+kobe.LIG);
            Console.WriteLine("TAKIM: "+kobe.TAKIM);
            Console.WriteLine("POZİSYON: "+kobe.POZİSYON);


            Console.ReadLine();



        }
    }
}
