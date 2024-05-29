using System;
using Task_3.BL;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Deck deck = new Deck();
            deck.ShuffleCards();
            while (check)
            {

                Card DealerCard1 = deck.DealCard();
                int cardValue1 = DealerCard1.GetValue();

                Console.WriteLine("Dealer Value is :" + cardValue1);
                Card DealerCard2 = deck.DealCard();
                int cardValue2 = DealerCard2.GetValue();

                BlackJackHand DealerHand = new BlackJackHand();
                DealerHand.AddCard(DealerCard1);
                DealerHand.AddCard(DealerCard2);

                int BlackJackValueDealer = DealerHand.GetBlackJackValue();

                while (BlackJackValueDealer <= 17)
                {
                    Card DealerCard = deck.DealCard();
                    int cardValue = DealerCard.GetValue();
                    BlackJackValueDealer += cardValue;
                }


                Card Playercard1 = deck.DealCard();
                int PlayerValue1 = Playercard1.GetValue();

                Card Playercard2 = deck.DealCard();
                int PlayerValue2 = Playercard2.GetValue();

                BlackJackHand PlayerHand = new BlackJackHand();
                PlayerHand.AddCard(Playercard1);
                PlayerHand.AddCard(Playercard2);
                int PlayerBlackJackValue = PlayerHand.GetBlackJackValue();
                while (true)
                {
                    PlayerBlackJackValue = PlayerHand.GetBlackJackValue();
                    Console.WriteLine("Your Total BlackJackCardValue is :" + PlayerBlackJackValue);
                    Console.Write("If you Want to Get More Card Enter Y: ");
                    string input = Console.ReadLine();
                    if (input == "Y")
                    {
                        Card Playercard = deck.DealCard();
                        int PlayerValue = Playercard.GetValue();
                        PlayerHand.AddCard(Playercard);
                    }
                    else
                    {
                        break;
                    }

                }

                if (PlayerBlackJackValue == 21)
                {
                    Console.WriteLine("Your Value is 21 You Have Won");
                    break;
                }
                else if(PlayerBlackJackValue > 21) 
                {
                    Console.WriteLine("Your Value is Greater Than 21 You Have Lost");
                    Console.WriteLine("Your Value is " + PlayerBlackJackValue);
                    break;
                }
                else if (BlackJackValueDealer == 21)
                {
                    Console.WriteLine("Dealer Value is 21 You Have Lost");
                    break;
                }
                else if (BlackJackValueDealer > 21)
                {
                    Console.WriteLine("Dealer Value is Greater Than 21 You Have Won");
                    Console.WriteLine("Dealer Value is " + BlackJackValueDealer);
                    break;
                }
                else if (BlackJackValueDealer > PlayerBlackJackValue)
                {
                    Console.WriteLine("Dealer Value is Greater You Lost");
                    Console.WriteLine("Dealer Value is " + BlackJackValueDealer);
                    Console.WriteLine("Your Value is " + PlayerBlackJackValue);
                    break;
                }
                else if (BlackJackValueDealer < PlayerBlackJackValue)
                {
                    Console.WriteLine("Dealer Value is Lesser You Won");
                    Console.WriteLine("Dealer Value is " + BlackJackValueDealer);
                    Console.WriteLine("Your Value is " + PlayerBlackJackValue);
                    break;
                }
            }
                Console.ReadLine();
        }
    }
}
