using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gra_karciana_ryby_
{
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        /*  stary Name
        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }
        */


        //początek nowego kodu
        
            private static string[] names0 = new string[]
            {
                "","asów","dwójek","trójek","czwórek","piątek","szóstek","siódemek","ósemek","dziewiątek","dziesiątek","waletów","dam","króli"
            };
            private static string[] names1 = new string[]
            {
                "","asa","dwójkę","trójkę","czwórkę","piątkę","szóstkę","siódemkę","ósemkę","dziewiątkę","dziesiątkę","waleta","damę","króla"
            };
            private static string[] names2 = new string[]
            {
                "","asy","dwójki","trójki","czwórki","piątki","szóstki","siódemki","ósemki","dziewiątki","dziesiątki","walety","damy","króle"
            };
        public static string Plural(Values value, int count)
        {
            if (count == 0) return names0[(int)value];
            if(count ==1) return names1[(int)value];
            return names2[(int)value];
        }

        private static string[] suits = new string[] { "pik", "trefl", "karo", "kier" };
        private static string[] names = new string[] { "", "As", "Dwójka", "Trójka", "Czwórka", "Piątka", "Szóstka", "Siódemka", "Ósemka", "Dziewiątka", "Dziesiątka", "Walet", "Dama", "Król" };
       
        public string Name
        {
            get { return names[(int)Value] + " " + suits[(int)Suit]; }
        }

        
        

        //koniec nowego kodu

    }
    enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts
    }
    enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Fourth = 4,
        Five = 5,
        Six = 6,
        Seventh = 7,
        Eventh = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }
    
}
