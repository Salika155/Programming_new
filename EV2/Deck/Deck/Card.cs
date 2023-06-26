using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    enum SuitCard
    {
        GOLD,
        CUP,
        STICK,
        SWORD
    }

    internal class Card
    {
        private int _number;
        private SuitCard _suit;

        private int number;
        public int Number {get { return number; } }
        public SuitCard suit { get { return suit; } }

        public Card(int number, SuitCard suit)
        {
            _number = number;
            _suit = suit;
        }

        public Card()
        {
            _number = 1;
            _suit = SuitCard.GOLD;
        }


    }
}
