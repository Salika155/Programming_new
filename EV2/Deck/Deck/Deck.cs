using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Deck
{
    internal class Deck
    {
        private List<Card> cards;
        private Random _random;

        public int cardCount
        { get { return cards.Count; }}

        public Deck()
        {
            cards = new List<Card>();
            _random = new Random();
            
        }
     
        public Card GetCardInPosition(int position)
        {
            if (position >= 0 && position < cards.Count)
            {
                return cards[position];
            }
            else
            {
                return null;
            }
        }

        public Card ExtractCardInPosition(int position) 
        {
            if (position >= 0 && position > cards.Count)
            {
                Card card = cards[position];
                cards.RemoveAt(position);
                return card;
            }
            else
            {
                return null;
            }
        }

        public Card ExtractCard(int numCarta, SuitCard suitcard)
        {
            int index = FindCardAtIndex(numCarta, suitcard);
            return ExtractCardInPosition(index);  
        }

        public int FindCardAtIndex(int index, SuitCard suitcard)
        {
            for (int i = 0; i < cardCount; i++)
            {
                var c = cards[i];
                if (c.Number == index && c.suit == suitcard)
                    return i;
            }
            return -1;
        }

        public void AddCard(Card card) 
        {
            if (!cards.Contains(card))
            cards.Add(card);
        }

        public void AddCard(int numCarta, SuitCard suit)
        {
            Card card = new Card (numCarta, suit);
            cards.Add(card);
        }

        public void SuffleCards()
        {
            for (int i = 0; i < cardCount; i++)
            {
                int j = Utils.GetRandomInteger(0, i);
                SwapCards(i, j);
            }
        }

        public void SwapCards(int index1, int index2)
        {
            Card aux = cards[index1];
            cards[index1] = cards[index2];
            cards[index2] = aux;
        }


        public List<Card> ExtractFirstsCards(int numCards)
        {
            if (numCards >= 0 && numCards <= cardCount)
            {
                List<Card> extractedCards = new List<Card>();
                for (int i = 0; i < numCards; i++)
                {
                    Card extractedCard = RemoveCard(0);
                    extractedCards.Add(extractedCard);
                }
                return extractedCards;
            }
            else
            {
                return null;
            }
        }


        public Card RemoveCard(int numCards)
        {
            if (numCards < 0 && numCards >= cardCount)
            {
                return null;
            }
            Card extractedCard = cards[numCards];
            cards.RemoveAt(numCards);
            return extractedCard;
        }


        public void ResetCards() 
        {
            cards.Clear();
            //foreach (SuitCard suit in cards && Card _number)
            {
                for (int num = 0; num <= 13; num++)
                {
                    Card card = new Card();
                    cards.Add(card);
                }
            }

        }

    }
}
