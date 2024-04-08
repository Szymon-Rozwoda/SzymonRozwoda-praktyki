using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator_przyjec
{
    
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty() { NumberOfPeople =5};
            dinnerParty.CalculateCostOfDecorations(false);
            dinnerParty.SetHealthyOption(true);
            DisplayDinnerPartyCost();



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(checkBox1.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(checkBox2.Checked);
            DisplayDinnerPartyCost();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(checkBox2.Checked);
            label3.Text = Cost.ToString("c");
        }
    }
}
