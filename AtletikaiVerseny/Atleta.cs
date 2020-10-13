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

        public Atleta(string sor)
        {
            string[] a = sor.Split(';');
            string[] nev = sor.Split(' ');
            Rajtszam = a[0];
            VezNev = nev[0];
            KerNev = nev[1];
            Egyesulet = a[1];
            Ugras = Convert.ToInt32(a[2]);

            //string[] Nev = new string[] { };
            //Nev = VezNev + KerNev;
        }

    }
}
