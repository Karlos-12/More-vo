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
        int choise = 0;

        public Window1()
        {
            InitializeComponent();
        }

        private void clasic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            choise = 1;
            Hide();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            choise = 2;
            Hide();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            choise = 3;
            Hide();
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            choise = 4;
            Hide();
        }
    }
}
