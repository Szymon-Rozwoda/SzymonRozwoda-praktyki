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

namespace if_else_instrukcja
{
    /// <summary>
    /// Logika interakcji dla klasy Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void zmiana_tekstu_Click(object sender, RoutedEventArgs e)
        {
            if(checkBox.IsChecked == true)
            {
                if(label_do_zmiany.Text=="Z prawej")
                {
                    label_do_zmiany.Text = "Z lewej";
                    label_do_zmiany.HorizontalAlignment = HorizontalAlignment.Left;
                }
                else
                {
                    label_do_zmiany.Text = "Z prawej";
                    label_do_zmiany.HorizontalAlignment = HorizontalAlignment.Right;
                }
            }
            else
            {
                label_do_zmiany.Text = "Możliwoś zmiany tekstu wyłączona";
                label_do_zmiany.HorizontalAlignment = HorizontalAlignment.Center;
            }
        }
    }
}
