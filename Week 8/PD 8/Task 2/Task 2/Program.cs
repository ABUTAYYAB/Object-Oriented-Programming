using System;
using Task_2.BL;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Deck deck = new Deck();
            deck.ShuffleCards();
            int Score = 0;
            int TimesPlayed = 0;
            while (check)
            {
                TimesPlayed++;
                Card card = deck.DealCard();
                string ValueString = card.GetValueAsString();
                int cardValue = card.GetValue();
                Console.WriteLine("Card is " + ValueString);

                Card card2 = deck.DealCard();
                int cardValue2 = card2.GetValue();

                Console.Write("Enter Your Prediction : ");
                string inputValue = Console.ReadLine();

                if (inputValue == "High" && (cardValue2 > cardValue))
                {
                    Score++;
                    continue;
                }
                else if (inputValue == "Low" && (cardValue2 < cardValue))
                {
                    Score++;
                    continue;
                }
                else
                {
                    break;
                }


            }
            Console.WriteLine("You Have Played :" + TimesPlayed + "Times");
            Console.WriteLine("Your Score is :" + Score);
            Console.WriteLine("Your Average is  :" + Score/ TimesPlayed);

            Console.ReadLine();



        }
    }
}
