using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stolowka_drwali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if(radioButton1.Checked == true)
            {
                food = Flapjack.Chrupkiego;
            }
            else if(radioButton2.Checked == true)
            {
                food = Flapjack.Wilgotnego;
            }
            else if(radioButton3.Checked == true)
            {
                food = Flapjack.Rumianego;
            }
            else
            {
                food = Flapjack.Banannowego;
            }
            Lumberjack currentLumberjack =breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
            RedrawList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(name.Text)) return;
            breakfastLine.Enqueue(new Lumberjack(name.Text));
            name.Text = "";
            RedrawList();
        }
        private void RedrawList()
        {
            int number = 1;
            line.Items.Clear();
            foreach(Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(number+". "+lumberjack.Name);
            }
        }
    }
    //lumberjacks

    public class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;
        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }
        public int FlapjackCount { get { return meal.Count; } }
        public void TakeFlapjacks(Flapjack food, int HowMany)
        {
            for (int i = 0; i < HowMany; i++)
            {
                meal.Push(food);
            }
        }
        public void EatFlapjacks()
        {
            Console.WriteLine(name + " je naleśniki");
            while (meal.Count > 0)
            {
                Console.WriteLine(name+" zjadł "+meal.Pop().ToString().ToLower()+" naleśnika");
            }
        }

    }
    public enum Flapjack
    {
        Chrupkiego,
        Wilgotnego,
        Rumianego,
        Banannowego
    }
}
