using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace More_čávo
{
    /// <summary>
    /// Interakční logika pro Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public int choise = 0;
        public int hodnota = 0;
        public int who = 0;
        
        Čavo _1 = null;
        Čavo _2 = null;

        public Window1()
        {
            InitializeComponent();
        }

        public void Show(Čavo __1, Čavo __2, int wh)
        {
           who = wh;
            _1 = __1;
            _2 = __2;
            Show();
        }

        private void clasic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            choise = 1;
            hodnota = 20;
            if (who == 0)
            {
                _1.vybrano(hodnota);
            }
            else if(who == 1)
            {
                _2.vybrano(hodnota);
            }
            Hide();

        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            choise = 2;
            hodnota = 25;
            if (who == 0)
            {
                _1.vybrano(hodnota);
            }
            else if (who == 1)
            {
                _2.vybrano(hodnota);
            }
            Hide();

        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            choise = 3;
            hodnota = 25;
            if (who == 0)
            {
                _1.vybrano(hodnota);
            }
            else if (who == 1)
            {
                _2.vybrano(hodnota);
            }
            Hide();
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            choise = 4;
            hodnota = 35;
            if (who == 0)
            {
                _1.vybrano(hodnota);
            }
            else if (who == 1)
            {
                _2.vybrano(hodnota);
            }
            Hide();
        }
    }
}
