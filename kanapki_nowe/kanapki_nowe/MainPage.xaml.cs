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

using System.Collections.ObjectModel;
using System.ComponentModel;

namespace kanapki_nowe
{
    /// <summary>
    /// Logika interakcji dla klasy MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        MenuMaker menuMaker=new MenuMaker();
        public MainPage()
        {
            InitializeComponent();
            pageLayoutStackPanel.DataContext = menuMaker;
        }


        private void newMenu_Click(object sender, RoutedEventArgs e)
        {
            menuMaker.UpdateMenu();
        }
    }
    class MenuMaker
    {
        private Random random = new Random();
        private List<String> meats = new List<String>() { "Pieczona wołowina", "Salami", "Indyk", "Szynka", "Karkówka" };
        private List<String> condiments = new List<String>() { "żółta musztarda", "brązowa musztarda", "musztarda mioodwa", "majonez", "przyprawa w płynie", "sos francuski" };
        private List<String> breads = new List<String>() { "chleb ryżowy", "chleb biały", "chleb zbożowy", "pumpernikiel", "chleb włoski", "bułka" };

        public ObservableCollection<MenuItem> Menu { get; private set; }
        public DateTime GeneratedDate { get; set; }
        public int NumberOfItems { get; set; }
        public MenuMaker()
        {
            Menu = new ObservableCollection<MenuItem>();
            NumberOfItems = 10;
            UpdateMenu();
        }
        private MenuItem CreateMenuItem()
        {
            string randomMeat = meats[random.Next(meats.Count)];
            string randomCondiment = condiments[random.Next(condiments.Count)];
            string randomBread = breads[random.Next(breads.Count)];
            return new MenuItem(randomMeat,randomCondiment, randomBread);
        }
        public void UpdateMenu()
        {
            Menu.Clear();
            for (int i = 0; i < NumberOfItems; i++)
            {
                Menu.Add(CreateMenuItem());
            }
            GeneratedDate = DateTime.Now;
            OnPropertyChanged("GeneratedDate");
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;
            if (propertyChangedEvent != null)
            {
                propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    class MenuItem
    {
        public string Meat { get; private set;}
        public string Condiment { get; private set;}
        public string Bread { get; private set;}

        public MenuItem(string meat, string condiment, string bread)
        {
            Meat = meat;
            Condiment = condiment;
            Bread = bread;
        }
        public override string ToString()
        {
            return Meat+", "+Condiment+", "+Bread;
        }
    }
}
