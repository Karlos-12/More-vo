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
        Window win = null;

        public Window1()
        {
            InitializeComponent();
        }

        public void Show(Window window)
        {
            win = window;
            Show();
        }

        private void clasic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            choise = 1;
            hodnota = 20;
            if (who == 0)
            {
              // win.
            }
            Hide();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            choise = 2;
            hodnota = 25;
            Hide();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            choise = 3;
            hodnota = 25;
            Hide();
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            choise = 4;
            hodnota = 35;
            Hide();
        }
    }
}
