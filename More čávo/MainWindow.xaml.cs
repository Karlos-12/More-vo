 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace More_čávo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Čavo Tomsn1 = new Čavo("Tomsn", "Blaohulič", new DateTime(2006, 3, 21), 100, 100, 0, 27);
        Čavo Marian1 = new Čavo("Marian", "Čavočum", new DateTime(2006, 5, 12), 100, 100, 0, 25);
        int who = 0;


        public MainWindow()
        {
            InitializeComponent();
            write();
        }

        public void write()
        {
            t1.Text = ("Name: " + Tomsn1.name + " " + Tomsn1.surname  + "\nBirth: " + Tomsn1.birth + "\nEnergdzi: " + Tomsn1.enerdzi + "\nLife: " + Tomsn1.life + "\nXP: " + Tomsn1.Xpcka);
            t2.Text = ("Name: " + Marian1.name + " " + Marian1.surname + "\nBirth: " + Marian1.birth + "\nEnergdzi: " + Marian1.enerdzi + "\nLife: " + Marian1.life + "\nXP: " + Marian1.Xpcka);

        }

        private void sw_Click(object sender, RoutedEventArgs e)
        {
            if(who == 0)
            {
                who++;
                t1.BorderBrush = new SolidColorBrush(Color.FromArgb(128, 0, 0, 0));
                t2.BorderBrush = new SolidColorBrush(Color.FromArgb(128, 128, 0, 0));
            }
            else 
            {
                who--;
                t2.BorderBrush = new SolidColorBrush(Color.FromArgb(128, 0, 0, 0));
                t1.BorderBrush = new SolidColorBrush(Color.FromArgb(128, 128, 0, 0));
            }
        }

        private void atack_click(object sender, RoutedEventArgs e)
        {
            switch(who)
            {
                case 0:
                    Tomsn1.Čavoatack(Marian1);
                    write();
                    break;

                case 1:
                    Marian1.Čavoatack(Tomsn1);
                    write();
                    break;
                    
            }
        }

        private void glob_click(object sender, RoutedEventArgs e)
        {
            switch (who)
            {
                case 0:
                   
                    break;

                case 1:
                  
                    break;

            }
        }
    }
}
