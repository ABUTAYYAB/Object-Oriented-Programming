using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.BL
{
    internal class Hand
    {
        List<Card> CardsInHand = new List<Card>();
        public Hand() { }

        public void ClearHand()
        {
            CardsInHand.Clear();
        }
        public void AddCard(Card card) 
        {
            if(card != null)
            {
                CardsInHand.Add(card);
            }
        }
        public void RemoveCard(Card card) 
        {
            if(card != null) 
            {
                CardsInHand.Remove(card);
            }
        }
        public void RemoveCard(int position)
        {
           
                CardsInHand.RemoveAt(position);
        }
        public int GetCardCount()
        {
            return CardsInHand.Count + 1;
        }
        public Card GetCard(int position) 
        {
            Card card = CardsInHand[position];
            return card;
        }
        public void SortBySuit()
        {
            int index = 0;

            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    for (int i = index; i < CardsInHand.Count; i++)
                    {
                        if (CardsInHand[i].GetSuit() == suit && CardsInHand[i].GetValue() == value)
                        {
                            if (i != index)
                            {
                                Card temp = CardsInHand[i];
                                CardsInHand[i] = CardsInHand[index];
                                CardsInHand[index] = temp;
                            }
                            index++;
                            break;
                        }
                    }
                }
            }
        }
        public void SortByValue()
        {
            for (int i = 0; i < CardsInHand.Count - 1; i++)
            {
                for (int j = 0; j < CardsInHand.Count - i - 1; j++)
                {
                    if (CardsInHand[j].GetValue() > CardsInHand[j + 1].GetValue())
                    {
                        Card temp = CardsInHand[j];
                        CardsInHand[j] = CardsInHand[j + 1];
                        CardsInHand[j + 1] = temp;
                    }
                    else if (CardsInHand[j].GetValue() == CardsInHand[j + 1].GetValue())
                    {
                        if (CardsInHand[j].GetSuit() > CardsInHand[j + 1].GetSuit())
                        {
                            Card temp = CardsInHand[j];
                            CardsInHand[j] = CardsInHand[j + 1];
                            CardsInHand[j + 1] = temp;
                        }
                    }
                }
            }
        }
    }
}
