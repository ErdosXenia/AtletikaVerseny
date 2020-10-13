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
        public string Nev { get; private set; }
        //public string KerNev { get; private set; }
        public string Egyesulet { get; private set; }
        public int Ugras { get; private set; }

        public Atleta(string sor)
        {
            string[] a = sor.Split(';');
            Rajtszam = a[0];
            Nev = a[1];
            //KerNev = nev[1];
            Egyesulet = a[2];
            Ugras = int.Parse(a[3]);

            //string[] Nev = new string[] { };
            //Nev = VezNev + KerNev;
        }

    }
}
