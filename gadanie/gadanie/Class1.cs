using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gadanie
{
    internal class Class1
    {
        public static int rozmowa(string coMowisz, int ileRazy)
        {
            string tenString = "";
            for(int licz = 1; licz<=ileRazy; licz++)
            {
                tenString = tenString + coMowisz + "\n";
            }
            MessageBox.Show(tenString);
            return tenString.Length;
        }
    }
}
