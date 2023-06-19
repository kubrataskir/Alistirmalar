using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class mobilya
    {
        public string renk;

        abstract public void ozellikyaz();

    }
    class kanepe : mobilya
    {
        public string kumas;

        public override void ozellikyaz()
        {
            Console.WriteLine("Kanepenin Özellikleri");
            Console.WriteLine("Renk: {0} ", renk);
            Console.WriteLine("Kumaş: {0} ", kumas);
        }
    }
    class masa : mobilya
    {
        public string malzeme;
        public override void ozellikyaz() 
        {
            Console.WriteLine("Masanın Özellikleri");
            Console.WriteLine("Renk: {0} ",renk);
            Console.WriteLine("Malzeme: {0} ",malzeme);
        }

    }






}
