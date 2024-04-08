using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzien_na_wyscigach
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLenght;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;



        public bool Run()
        {
            int move = MyRandom.Next(1, 4);
            Location = Location + move;
            MyPictureBox.Left = StartingPosition + Location;
            if (MyPictureBox.Left >= RacetrackLenght)
            {
                return true;
            }
            else 
            { 
                return false;
            }
            
            
        }
        public void TakeStartingPosiotion()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
