namespace Dzien_na_wyscigach
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;


        public string GetDescription()
        {
            string description;
            if (Amount > 0)
            {
                 description = Bettor.Name + " postawił " + Amount + " zł na psa numer " + Dog;
            }
            else
            {
                 description = Bettor.Name + " nie zawarł zakładu";
            }
          
            return description;
        }
        public int PayOut(int Winner)
        {
            if (Dog == Winner)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }

        }
    }
}
