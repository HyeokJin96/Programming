using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class TrumpCard
    {
        private int[] trumpCardset;
        private string[] trumCardMark;

        public void SetupTrumpCards()
        {
            trumpCardset = new int[52];

            for (int i = 0; i < trumpCardset.Length; i++)
            {
                trumpCardset[i] = i + 1;
                Console.Write("{0} ", trumpCardset[i]);
            }       //  loop : 카드의 숫자를 셋업하는 루프

            //  트럼프 카드의 마크를 셋업
            trumCardMark = new string[4] { "♥", "♠", "◆", "♣" };
        }       //  setupTrumpCards()

        //! 카드를 섞는 함수
        public void shuffleCards()
        {
            shuffleCards(200);
        }
        //! 카드를 섞는 함수

        //! 한장의 카드를 뽑아서 보여주는 함수

        //! 셔플 하고서 카드를 한 장 뽑아서 출력하는 함수
        public void ReRollcard()
        {
            shuffleCards();
            Rollcard();
        }
        public void Rollcard()
        {
            int card = trumpCardset[0];
            string cardMark = trumCardMark[(card - 1/ 13) / 13];
            string cardNumber = Math.Ceiling(card % 13.1).ToString();

            switch (cardNumber)
            {
                case "11":
                    cardNumber = "J";
                    break;
                case "12":
                    cardNumber = "Q";
                    break;
                case "13":
                    cardNumber = "K";
                    break;
                default:
                    /* Do nothing */
                    break;
            }

            Console.WriteLine("내가 뽑은 카드는 {0}{1} 입니다.", cardMark, cardNumber);
            Console.WriteLine("-------");
            Console.WriteLine("l {0}{1} l", cardMark, cardNumber);
            Console.WriteLine("l     l");
            Console.WriteLine("l {0}{1} l", cardNumber, cardMark);
            Console.WriteLine("-------");
        }

        private void printCardset()
        {
            foreach (int card in trumpCardset)
            {
                Console.Write("{0} ", card);
            }
        }

        private void shuffleCards(int howManyLoop)
        {
            for (int i = 0; i < howManyLoop; i++)
            {
                trumpCardset = shuffleOnece(trumpCardset);
            }
        }

        private int[] shuffleOnece(int[] intArray)
        {
            Random random = new Random();
            int sourceIndex = random.Next(0, intArray.Length);
            int destIndex = random.Next(0, intArray.Length);

            int tempVarible = intArray[sourceIndex];

            intArray[sourceIndex] = intArray[destIndex];
            intArray[destIndex] = tempVarible;

            return intArray;
        }       //  shuffle
    }       //  class TrumpCard
}
