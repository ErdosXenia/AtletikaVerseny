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
        static Dictionary<string, int> feladat = new Dictionary<string, int>();

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
                Console.WriteLine("{0,10} {1,15}",a.Nev,a.Ugras);
            }
        }

        //static void feladat3()
        //{
        //    Console.WriteLine("\n3. Feladat: Egyesületek: ");
        //    foreach (var a in atletak)
        //    {
        //        if (feladat.ContainsKey(a.Egyesulet))
        //        {
        //            feladat.Add(a.Egyesulet)++;
        //        }
        //    }
        //}

        static void feladat4()
        {
            Console.WriteLine("4. Feladat: Legnagyobb ugrás:");
            int max = 0;
            foreach (var a in atletak)
            {
                if (max > a.Ugras)
                {
                    max = a.Ugras;
                }
                Console.Write(a.Nev);
                
            }
            Console.WriteLine($": {max}");
        }

        static void feladat5()
        {

        }

        static void Main(string[] args)
        {
            feladat1();
            feladat2();
            //feladat3();
            feladat4();

            Console.ReadKey();
        }
    }
}
