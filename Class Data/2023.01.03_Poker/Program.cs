using System;
using System.Security.Cryptography.X509Certificates;

namespace _2023._01._03_Poker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  LAB. 포커게임

            //  * 컴퓨터와 플레이어가 5장의 카드를 뽑는다.
            //  * 플레이어가 배팅을 한다. (최초 소지금 = 10,000 포인트)
            //  * 컴퓨터는 추가로 2장의 카드를 받는다.
            //  * 플레이어는 최대 2장의 카드를 교체할 수 있다.
            //  * 모든 액션이 끝난 후에는 결과를 체크한다.
            //  * 플레이어 승리시 배팅 금액의 2배를 얻는다.
            //  * 플레이어의 소지금이 100,000 포인트 이상이 되거나 전부 잃으면 게임을 종료한다.
            //  * 족보 : Top ~ straight (기본형)
            //  * 전체 족보 (도전)

            //  1. 52장의 카드를 생성한다.
            //  2. 생성된 카드 52장을 섞는다. -> 덱 생성
            //  3. 생성된 덱에서 컴퓨터의 카드를 뽑은 후 출력한다.
            //  4. 플레이어가 배팅을 한다.
            //  5. 컴퓨터가 덱에서 2장의 카드를 추가로 뽑은 후 출력한다.
            //  6. 플레이어가 덱에서 5장의 카드를 뽑은 후 최대 2장의 카드를 교환할지 결정한다.
            //  7. 결과를 출력한다.

            Program Poker = new Program();
            Poker.Computerdeck();

        }       //  Main ()


        public void Deck()
        {
            int[] trumpcardNumber = new int[52];     //  52장의 카드를 생성
            string[] trumpcardMark = new string[4] {"♠", "◆", "♥", "♣" };

            Random random = new Random();

            for (int i = 0; i < trumpcardNumber.Length; i++)     //  생성된 52장의 카드에 숫자를 출력
            {
                trumpcardNumber[i] = i + 1;
            }

            trumpcardNumber = trumpcardNumber.OrderBy(x => random.Next()).ToArray();      //  생성된 52장의 카드를 섞음

            string cardNumber = Math.Ceiling(trumpcardNumber[0] % 13.1).ToString();
            string cardMark = trumpcardMark[(trumpcardNumber[0] - 1) / 13];

            switch (cardNumber)
            {
                case  "1": cardNumber = "A"; break;
                case "11": cardNumber = "J"; break;
                case "12": cardNumber = "Q"; break;
                case "13": cardNumber = "K"; break;
            }

            Console.WriteLine("{0}, {1}", cardMark, cardNumber);

        }       //  Deck ()

        public void Computerdeck()
        {

        }

    }       //  class Program
}       //  namespace