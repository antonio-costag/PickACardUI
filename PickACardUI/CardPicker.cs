using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCardes)
        {
            string[] pickedCards = new string[numberOfCardes];
            for (int i = 0; i < numberOfCardes; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            //Obter um número aleatório entre 1 a 4
            int value = random.Next(1, 5);
            //Se o número for 1, retorne "Spades"
            if (value == 1) return "Spades";
            //Se o número for 2, retorne "Hearts"
            if (value == 2) return "Hearts";
            //Se o número for 3, retorne "Clubs"
            if (value == 3) return "Clubs";
            //Se não retornamos, retornar a string "Diamonds"
            return "Diamonds";
        }

        private static string RandomValue()
        {
            //Obter um número aleatório entre 1 a 13
            int value = random.Next(1, 14);
            //Se o número for 1, retorne "Ace"
            if (value == 1) return "Ace";
            //Se o número for 11, retorne "Jack"
            if (value == 11) return "Jack";
            //Se o número for 12, retorne "Queen"
            if (value == 12) return "Queen";
            //Se o número for 13, retorne "King"
            if (value == 13) return "King";
            //Se não retornamos, retornar o valor convertido para string
            return value.ToString();
        }
    }
}
