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
            StreamReader sr = new StreamReader("tavol.csv");
            while (!sr.EndOfStream)
            {
                atletak.Add(new Atleta(sr.ReadLine()));
            }
            sr.Close();
        }

        static void Main(string[] args)
        {
            feladat1();

            Console.ReadKey();
        }
    }
}
