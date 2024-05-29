using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.BL
{
    internal class Card
    {
        public Card(int value,int suit) 
        {
            this.Value = value;
            this.Suit = suit;
        }
        private int Value, Suit;

        public void SetValue(int value) 
        {
            this.Value = value;
        }
        public int GetValue()
        {
            return Value;
        }
        public string GetValueAsString()
        {
            string result;
            if(this.Value == 1)
            {
                result = "Ace";
            }
            else if(this.Value == 2) 
            {
                result = "Two";
            }
            else if (this.Value == 3)
            {
                result = "Three";
            }
            else if (this.Value == 4)
            {
                result = "Four";
            }
            else if (this.Value == 5)
            {
                result = "Five";
            }
            else if (this.Value == 6)
            {
                result = "Six";
            }
            else if (this.Value == 7)
            {
                result = "Seven";
            }
            else if (this.Value == 8)
            {
                result = "Eight";
            }
            else if (this.Value == 9)
            {
                result = "Nine";
            }
            else if (this.Value == 10)
            {
                result = "Ten";
            }
            else if (this.Value == 11)
            {
                result = "Jack";
            }
            else if (this.Value == 12)
            {
                result = "Queen";
            }
            else if (this.Value == 13)
            {
                result = "King";
            }
            else
            {
                result = "";
            }
            return result;
        }
        public void SetSuit(int suit) 
        {
            this.Suit = suit;
        }
        public int GetSuit() 
        {
            return Suit;
        }
        public string GetSuitAsString()
        {
            string result;
            if (this.Value == 1)
            {
                result = "Clubs";
            }
            else if (this.Value == 2)
            {
                result = "Diamonds";
            }
            else if (this.Value == 3)
            {
                result = "Spades";
            }
            else if (this.Value == 4)
            {
                result = "Hearts";
            }
            else
            {
                result = "";
            }
            return result;
        }

        public string Tostring()
        {
            string result;
            result = "'"+GetValueAsString()+ "'of '"+ GetSuitAsString() + "'";
            return result;
        }
    }
}
