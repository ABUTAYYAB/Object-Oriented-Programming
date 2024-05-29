using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.BL
{
    internal class Deck
    {
        private List<Card> cards;
        private int CardsLeft;
        public Deck()
        {
            cards = new List<Card>();
            cards = GetCards();
            CardsLeft = 52;
        }
        private List<Card> GetCards()
        {
            List<Card> deck = new List<Card>();
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    deck.Add(new Card(value, suit));
                }
            }

            return deck;
        }
        public void ShuffleCards()
        {
            Random rand = new Random();
            int n = cards.Count;
            if (cards.Count < 51)
            {
                cards.Clear();
                cards = GetCards();
            }
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Card temp = cards[k];
                cards[k] = cards[n];
                cards[n] = temp;
            }
        }
        public int Cardsleft()
        {
            return this.CardsLeft;
        }
        public Card DealCard()
        {
            if (cards.Count == 0)
            {
                return null;
            }

            Random rand = new Random();
            int index = rand.Next(cards.Count);
            Card drawnCard = cards[index];
            cards.RemoveAt(index);
            return drawnCard;
        }
    }
}
