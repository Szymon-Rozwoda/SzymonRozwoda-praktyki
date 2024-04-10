using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Joe_Bob
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpdateForm()
        {
            label1.Text = joe.Name + " ma " + joe.Cash + " zł";
            label2.Text = bob.Name + " ma " + bob.Cash + "zł ";
            label3.Text = "Bank ma " + bank + " zł";
        }
        public Form1()
        {
            InitializeComponent();
            bob = new Guy() { Cash = 100, Name = "Bob" };
            //bob.Name = "Bob";
            //bob.Cash = 100;

            joe = new Guy() { Cash = 50, Name = "Joe" };
            //joe.Name = "Joe";
            //joe.Cash = 50;
            UpdateForm();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReciveCash(10);
                UpdateForm();
            }else
            {
                MessageBox.Show("Bank nie posiada takiej ilosci pieniedzy");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm() ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bob.ReciveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            joe.ReciveCash(bob.GiveCash(5));
            UpdateForm();
        }

        //serializacja
        

        private void button5_Click(object sender, EventArgs e)
        {
            using(Stream output = File.Create("Plik_Joe.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, joe);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using(Stream input = File.OpenRead("Plik_Joe.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                joe = (Guy)formatter.Deserialize(input);
            }
            UpdateForm();
        }
    }
}
