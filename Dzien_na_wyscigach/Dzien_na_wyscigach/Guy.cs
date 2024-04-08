using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzien_na_wyscigach
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLables()
        {
            MyRadioButton.Text = Name + " ma " + Cash + " złotych";
            MyLabel.Text = Name + " stawia " + MyBet.Amount + " zł na charta numer " + MyBet.Dog;
        }
        public void ClearBet()
        {
            MyBet = null;
        }
        public bool PlaceBet(int Amount, int DogToWin)
        {
            
            if(Amount <= Cash)
            {
                this.MyBet = new Bet();
                MyLabel.Text = Name + " stawia " + MyBet.Amount + " zł na charta numer " + MyBet.Dog;
                UpdateLables();
                return true;
            }
            else
            {
                MyLabel.Text = Name + " nie ma tyle pieniędzy";
                return false;
            }
        }
        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            ClearBet();
            UpdateLables();
        }
    }
}
