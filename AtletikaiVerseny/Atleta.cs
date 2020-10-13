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
            Rajtszam = a[0];
            VezNev = a[1];
            KerNev = a[2];
            Egyesulet = a[3];

            //string[] Nev = new string[] { };
            //Nev = VezNev + KerNev;
        }

    }
}
