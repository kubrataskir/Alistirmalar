using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            kanepe knp1= new kanepe();
            masa calisma_masasi=new masa();
            knp1.renk = "Siyah";
            knp1.kumas = "Keten";
            calisma_masasi.renk = "Kahverengi";
            calisma_masasi.malzeme = "Ahşap";
            knp1.ozellikyaz();
            Console.WriteLine();
            calisma_masasi.ozellikyaz();
            Console.ReadLine();

        }
    }
}
