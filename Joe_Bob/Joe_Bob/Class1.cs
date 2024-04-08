using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_Bob
{
    internal class Class1
    {
        
    }
    class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("Nie mam wystarczajaco duzo pieniedzy, aby ci dac " + amount, Name + " powiedzial...");
                return 0;
            }
        }
        public int ReciveCash(int amount)
        {
            if(amount >0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " to nie jest ilosc pieniedzy, jaka moge wziac ", Name + " powiedzial...");
                return 0;
            }
        }
    }
}
