using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator_przyjec3
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
            }
            return costOfBeveragesPerPerson;
        }
        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;

            }
        }
        }
    }
