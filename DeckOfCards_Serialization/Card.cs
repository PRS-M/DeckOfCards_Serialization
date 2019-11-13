using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards_Serialization
{
    [Serializable]
    class Card
    {
        public Card(Values value, Suits suit)
        {
            Suit = suit;
            Value = value;
        }

        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public string Name
        {
            get { return Value + " of " + Suit; }
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            if (cardToCheck.Value == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
