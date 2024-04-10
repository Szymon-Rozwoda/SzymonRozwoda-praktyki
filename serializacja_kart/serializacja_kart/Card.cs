using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializacja_kart
{
    [Serializable]
        class Card
        {
            public Suits Suit { get; set; }
            public Values Value { get; set; }

            public Card(Suits suit, Values value)
            {
                this.Suit = suit;
                this.Value = value;
            }
            public string Name
            {
                get
                {
                    return Value.ToString() + " of " + Suit.ToString();
                }
            }
        }
    [Serializable]
        enum Suits
        {
            Spades,
            Clubs,
            Diamonds,
            Hearts
        }
    [Serializable]
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

