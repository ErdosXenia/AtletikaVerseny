using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AtletikaiVerseny
{
    class Program
    {
        static List<Atleta> atletak = new List<Atleta>();

        static void feladat1()
        {
            Console.WriteLine("1. Feladat: Adatok beolvasása.");
            StreamReader sr = new StreamReader("tavol.csv");
            while (!sr.EndOfStream)
            {
                atletak.Add(new Atleta(sr.ReadLine()));
            }
            sr.Close();
        }

        static void feladat2()
        {
            Console.WriteLine("2. Feladat: Nevek és ugrások");
            foreach (var a in atletak)
            {
                Console.WriteLine("{0,10} {1} {2,10}",a.VezNev,a.KerNev,a.Ugras);
            }
        }

        static void Main(string[] args)
        {
            feladat1();
            feladat2();

            Console.ReadKey();
        }
    }
}
