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

namespace Kontrolki
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

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            String name = "Szymon";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            myLabel.Text = "imie: " + name + "\nx jest równe " + x + "\nd jest równe " + d;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                myLabel.Text = "x musi być równe 10";
            }
            else
            {
                myLabel.Text = "x nie jest równe 10";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int wartosc = 4;
            string imie = "Krzysiek";
            if((wartosc ==3) && (imie.Equals("Janek")))
            {
                myLabel.Text = "wartość jest równa 3 i imię to Janek";
            }
            myLabel.Text = "ten wiersz wykona się bez względu na warunki";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int count = 0;
            while(count<10)
            {
                count++;
            }
            for(int i = 0; i<5; i++)
            {
                count--;
            }
            myLabel.Text = "Odpowiedź brzmi " + count;
        }
    }
}
