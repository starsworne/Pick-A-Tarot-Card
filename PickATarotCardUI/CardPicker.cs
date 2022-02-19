using System;
using System.Collections.Generic;
using System.Text;

namespace PickATarotCardUI

{
    class CardPicker
        
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                string suit = RandomSuit();
                if (suit != "MajorArcana")
                {
                    pickedCards[i] = RandomValue() + " of " + suit;
                }
                else
                {
                    pickedCards[i] = RandomMajorArcana();
                }
                
            }
            return pickedCards;
        }

        private static string RandomMajorArcana()
        {
            int majorArcana = random.Next(1, 23);
            if (majorArcana == 1) return "0 - The Fool";
            if (majorArcana == 2) return "1 - The Magician";
            if (majorArcana == 3) return "2 - The High Priestess";
            if (majorArcana == 4) return "3 - The Empress";
            if (majorArcana == 5) return "4 - The Emperor";
            if (majorArcana == 6) return "5 - The Hierophant";
            if (majorArcana == 7) return "6 - The Lovers";
            if (majorArcana == 8) return "7 - The Chariot";
            if (majorArcana == 9) return "8 - Strength";
            if (majorArcana == 10) return "9 - The Hermit";
            if (majorArcana == 11) return "10 - Wheel of Fortune";
            if (majorArcana == 12) return "11 - Justice";
            if (majorArcana == 13) return "12 - The Hanged Man";
            if (majorArcana == 14) return "13 - Death";
            if (majorArcana == 15) return "14 - Temperance";
            if (majorArcana == 16) return "15 - The Devil";
            if (majorArcana == 17) return "16 - The Tower";
            if (majorArcana == 18) return "17 - The Star";
            if (majorArcana == 19) return "18 - The Moon";
            if (majorArcana == 20) return "19 - The Sun";
            if (majorArcana == 21) return "20 - Judgment";
            if (majorArcana == 22) return "21 - The World";
            return "MISTAKE";

        }

        private static string RandomSuit()
        {
            int suitValue = random.Next(1, 6);
            if (suitValue == 1) return "Wands";
            if (suitValue == 2) return "Chalices";
            if (suitValue == 3) return "Coins";
            if (suitValue == 4) return "Swords";
            else return "MajorArcana";
        }

        private static string RandomValue()
        {
            int valueOfCard = random.Next(1, 15);
            if (valueOfCard == 1) return "Ace";
            if (valueOfCard == 11) return "Page";
            if (valueOfCard == 12) return "Knight";
            if (valueOfCard == 13) return "Queen";
            if (valueOfCard == 14) return "King";
            return valueOfCard.ToString();

        }
    }
}
