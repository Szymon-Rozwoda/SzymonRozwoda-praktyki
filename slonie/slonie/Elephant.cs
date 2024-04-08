using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace slonie
{
    class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            MessageBox.Show("Moje uszy mają " + EarSize + " centymetrów szerokosci.", Name + " mówi...");
        }
    }
}
