namespace Task_3.BL
{
    internal class BlackJackHand : Hand
    {
        public int GetBlackJackValue()
        {
            int Value = 0;
            int AceCount = 0;

            for (int i = 0; i < CardsInHand.Count; i++)
            {
                int Tempvalue = CardsInHand[i].GetValue();
                if (Tempvalue == 1)
                {
                    if (AceCount < 1)
                    {
                        Value += 11;
                        AceCount++;
                    }
                    else
                    {
                        Value += Tempvalue;
                    }
                }
                else if (Tempvalue <= 10 && Tempvalue != 1)
                {
                    Value += Tempvalue;
                }
                else if (Tempvalue > 10)
                {
                    Value += 10;
                }

            }
            return Value;
        }

    }
}
