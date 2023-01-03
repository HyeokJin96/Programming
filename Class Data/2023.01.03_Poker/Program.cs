using System;

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
        }

        public void createCard()        //  52장의 카드를 생성하는 함수.
        {
            int[] card = new int[52];

            for (int i = 0; i < card.Length; i++)
            {
                card[i] = i + 1;
                Console.WriteLine(card[i]);
            }
        }

        public void shufflecards(int[] card)       //  52장의 카드를 섞는 함수. -> 덱 생성
        {
            Random random = new Random();

            card = card.OrderBy(n => Next.random()).ToArray();
        }
    }
}