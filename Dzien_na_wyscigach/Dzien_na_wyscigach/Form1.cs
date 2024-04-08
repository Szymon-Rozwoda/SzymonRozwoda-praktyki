using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzien_na_wyscigach
{
    public partial class Form1 : Form
    {
        Greyhound[] psy = new Greyhound[4];
        Guy[] osoby = new Guy[3];
        Random MyRandomizer = new Random();
        public Form1()
        {
            InitializeComponent();

            psy[0] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox1.Left,
                RacetrackLenght = pictureBox1.Width - pictureBox2.Width,
                //Randomizer = MyRandomizer
            };

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
