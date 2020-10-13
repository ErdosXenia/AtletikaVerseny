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
                atletak.Add( new Atleta(sr.ReadLine()));
            }
            sr.Close();
        }

        static void feladat2()
        {
            Console.WriteLine("2. Feladat: Nevek és ugrások");
            foreach (var a in atletak)
            {
                Console.WriteLine("{0,10} {1} {2,15}",a.VezNev,a.KerNev,a.Ugras);
            }
        }

        static void feladat3()
        {
            Console.WriteLine("\n3. Feladat: Egyesületek: ");
            foreach (var a in atletak)
            {
                if (feladat.ContainsKey(a.Egyesulet));
                {
                    //feladat.Add(feladat.Values(a.Egyesulet));
                }
            }
        }

        static void feladat4()
        {
            Console.WriteLine("\n4. Feladat: Legnagyobb ugrás:"); 
            int max = 0;
            foreach (var a in atletak)
            {
                if (max < a.Ugras)
                {
                    max = a.Ugras;
                    Console.Write("{0} {1}", a.VezNev, a.KerNev);
                }
                
                
            }
            Console.WriteLine($": {max}");
        }

        static void feladat5()
        {
            Console.Write("\n5. Feladat: Átlag alatt lévő ugrások száma: ");
            int db = 0;
            int atlag = 0;
            foreach (var a in atletak)
            {
                db++;
                atlag+=a.Ugras;
            }
            Console.WriteLine(atlag/db);

        }

        static void feladat6()
        {
            Console.WriteLine("\n6. feladat: Adatok fájlba írása.");
            StreamWriter sw = new StreamWriter("versenyzok.txt");
            foreach (var a in atletak)
            {
                sw.WriteLine($"{a.Rajtszam}; {a.VezNev} {a.KerNev}");
            }
            sw.Close();
        }

        static void Main(string[] args)
        {
            feladat1();
            feladat2();
            //feladat3();
            feladat4();
            feladat5();
            feladat6();

            Console.ReadKey();
        }
    }
}
