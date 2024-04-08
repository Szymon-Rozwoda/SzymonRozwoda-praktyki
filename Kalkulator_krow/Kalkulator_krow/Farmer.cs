using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_krow
{
    public class Farmer
    {
        public int BagsOfFeed { get; private set; }
        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }
        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;    
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }

        public Farmer(int numberOfCows, int feedMultipier) {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }
    }
}
