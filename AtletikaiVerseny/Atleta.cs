using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtletikaiVerseny
{
    class Atleta
    {
        public string Rajtszam { get;private set; }
        public string VezNev { get; private set; }
        public string KerNev { get; private set; }
        public string Egyesulet { get; private set; }
        public int Ugras { get; private set; }

        public Atleta(string sor,string nev)
        {
            string[] a = sor.Split(';');
            string[] b = nev.Split(' ');
            Rajtszam = a[0];
            VezNev = b[0];
            KerNev = b[1];
            Egyesulet = a[1];
            Ugras = int.Parse(a[2]);

            //string[] Nev = new string[] { };
            //Nev = VezNev + KerNev;
        }


    }
}
