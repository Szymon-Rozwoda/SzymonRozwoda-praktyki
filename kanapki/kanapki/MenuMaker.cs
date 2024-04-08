using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanapki
{
    public class MenuMaker
    {
        public Random Randomizer;

        string[] Meats = { "Pieczona wołowina", "Salami", "Indyk", "Szynka", "Karkówka" };
        string[] Condiments = { "żółta musztarad", "brązowa musztarda", "musztarda miodowa", "majonez", "przyprawa", "sos francuski" };
        string[] Breads = { "chleb ryzowy", "chleb biały", "chleb zbożowy", "pumpernikiel", "chleb wloski", "bułka" };

        public string GetMenuItem()
        {
            string randomMeaat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeaat + ", "+randomCondiment+ ", "+randomBread;
        }
    }
}
