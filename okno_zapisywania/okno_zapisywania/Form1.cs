using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okno_zapisywania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = @"C:\Users\xopero\Documents\GitHub\SzymonRozwoda-praktyki\okno_zapisywania\okno_zapisywania\Form1.cs";
            openFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt|" + "Pliki z wartościami oddzielonymi przecinkami (*.csv)|*.csv|" + "Wszystkie pliki (*.*)|*.*|";
            openFileDialog1.FileName = "plik_domyslny.txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = false;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //OpenSomeFile(openFileDialog1.FileName);  ?????
                
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        
    }
}
