using System;
using System.Collections.Generic;
using System.Text;

namespace More_čávo
{
    class Čavo
    {
        public string name { get; }
        public string surname { get; }
        public DateTime birth { get; }
        public int enerdzi { get; set; }
        public int life { get; set; }
        public int Xpcka { get; set; }
        

        public Čavo(string n, string srn, DateTime b, int eng, int lif, int xp)
        {
            name = n;
            surname = srn;
            birth = b;
            enerdzi = eng;
            life = lif;
            Xpcka = xp;
        }


    }
}
