using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace FlourishCards
{
    class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card? x, Card? y)
        {
            if(x.Value > y.Value)
                return 1;
            if(x.Value < y.Value)
                return -1;
            if(x.Suit> y.Suit)
                return 1;
            if(x.Suit < y.Suit)
                return -1;
            return 0;
        }
    }
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
                return Value.ToString()+" of "+Suit.ToString();
            }
        }
    }
    enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts,
    }
    enum Values
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }
}
