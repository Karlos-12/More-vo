using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace More_čávo
{
    public class Čavo
    {
        public string name { get; }
        public string surname { get; }
        public DateTime birth { get; }
        public int enerdzi { get; set; }
        public int life { get; set; }
        public int Xpcka { get; set; }
        public int atack { get; set; }
        public MainWindow w { get; set; }
        

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
        public void Winset(MainWindow win)
        {
            w = win;
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

       Window1 selec = new Window1();

        public void Monster_more()
        {
            if(life > 0)
            {
                
                
                selec.Show(w.Tomsn1, w.Marian1, w.who);
            }
            else
            { MessageBox.Show("Čavo si dead"); }
        }

        public void vybrano(int send)
        {
            switch (selec.choise)
            {
                case 0:
                    MessageBox.Show("Vyber něco hochu!");
                    break;
                default:
                    enerdzi += send;
                    break;

            }
            w.write();
        }

        public void jabkomore()
        {
            int r = 0;
            Random random = new Random();
            random.Next(0, 3);
            switch (r)
                {
                case 0:
                    life += 5;
                    break;
                case 1:
                    life += 10;
                    break;
                case 2:
                    life += 15;
                    break;
                case 3:
                    life += 20;
                    break;
            }          
        }

        public void tekutinka()
        {
            int hp = life;
            int ep = enerdzi;

            life = ep;
            enerdzi = hp;
        }

        public void morekralik()
        {
            Random random = new Random();
            int ch = random.Next(0, 1);
            switch (ch)
            {
                case 0:
                    life -= 20;
                    MessageBox.Show("měl vzteklinu čavo");
                    break;
                case 1:
                    Xpcka += 25;
                    MessageBox.Show("hedvábně hebký");
                    break;
            }
        }


    }
}
