using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

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
        public int atack { get; set; }
        

        public Čavo(string n, string srn, DateTime b, int eng, int lif, int xp, int at)
        {
            name = n;
            surname = srn;
            birth = b;
            enerdzi = eng;
            life = lif;
            Xpcka = xp;
            atack = at;
        }

        public void Čavoatack(Čavo _2)
        {
            if (enerdzi > 0! & life > 0)
            {
                _2.life -= atack;
                enerdzi -= 20;
                Xpcka += 10;
            }
            else
            {
                MessageBox.Show("!!!More nemáš enedrži!!!");
            }   
        }

        public void Monster_more()
        {
            if(life > 0)
            {
               mon
            }
            else
            { MessageBox.Show("Čavo si dead"); }
        }


    }
}
