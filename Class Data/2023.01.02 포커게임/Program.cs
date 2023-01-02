using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace _2023._01._02_포커게임
{
    public class TrumpCard
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

            int[] cardNumber = new int[52];
            string[] cardMark = new string[5] { "A", "♠", "◆", "♥", "♣" };

            Random random = new Random();


            for (int i = 0; i < cardNumber.Length; i++)     //  52장의 카드 생성
            {
                cardNumber[i] = i + 1;
            }
            cardMark = new string[4] { "♥", "♠", "◆", "♣" };        //  카드 문양

            cardNumber = cardNumber.OrderBy(x => random.Next()).ToArray();        //  카드 셔플

            int card_1 = cardNumber[0];
            string trumpCardmark_1 = cardMark[(card_1 - 1) / 13];
            string trumpCardnumber_1 = Math.Ceiling(card_1 % 13.1).ToString();

            switch (trumpCardnumber_1)
            {
                case "1":
                    trumpCardnumber_1 = "A";
                    break;
                case "11":
                    trumpCardnumber_1 = "J";
                    break;
                case "12":
                    trumpCardnumber_1 = "Q";
                    break;
                case "13":
                    trumpCardnumber_1 = "K";
                    break;
            }

            for (int i = 0; i < cardNumber.Length; i++)     //  52장의 카드 생성
            {
                cardNumber[i] = i + 1;
            }
            cardMark = new string[4] { "♥", "♠", "◆", "♣" };        //  카드 문양

            cardNumber = cardNumber.OrderBy(x => random.Next()).ToArray();        //  카드 셔플

            int card_2 = cardNumber[0];
            string trumpCardmark_2 = cardMark[(card_2 - 1) / 13];
            string trumpCardnumber_2 = Math.Ceiling(card_2 % 13.1).ToString();

            switch (trumpCardnumber_2)
            {
                case "1":
                    trumpCardnumber_2 = "A";
                    break;
                case "11":
                    trumpCardnumber_2 = "J";
                    break;
                case "12":
                    trumpCardnumber_2 = "Q";
                    break;
                case "13":
                    trumpCardnumber_2 = "K";
                    break;
            }

            for (int i = 0; i < cardNumber.Length; i++)     //  52장의 카드 생성
            {
                cardNumber[i] = i + 1;
            }
            cardMark = new string[4] { "♥", "♠", "◆", "♣" };        //  카드 문양

            cardNumber = cardNumber.OrderBy(x => random.Next()).ToArray();        //  카드 셔플

            int card_3 = cardNumber[0];
            string trumpCardmark_3 = cardMark[(card_3 - 1) / 13];
            string trumpCardnumber_3 = Math.Ceiling(card_3 % 13.1).ToString();

            switch (trumpCardnumber_3)
            {
                case "1":
                    trumpCardnumber_3 = "A";
                    break;
                case "11":
                    trumpCardnumber_3 = "J";
                    break;
                case "12":
                    trumpCardnumber_3 = "Q";
                    break;
                case "13":
                    trumpCardnumber_3 = "K";
                    break;
            }

            for (int i = 0; i < cardNumber.Length; i++)     //  52장의 카드 생성
            {
                cardNumber[i] = i + 1;
            }
            cardMark = new string[4] { "♥", "♠", "◆", "♣" };        //  카드 문양

            cardNumber = cardNumber.OrderBy(x => random.Next()).ToArray();        //  카드 셔플

            int card_4 = cardNumber[0];
            string trumpCardmark_4 = cardMark[(card_4 - 1) / 13];
            string trumpCardnumber_4 = Math.Ceiling(card_4 % 13.1).ToString();

            switch (trumpCardnumber_4)
            {
                case "1":
                    trumpCardnumber_4 = "A";
                    break;
                case "11":
                    trumpCardnumber_4 = "J";
                    break;
                case "12":
                    trumpCardnumber_4 = "Q";
                    break;
                case "13":
                    trumpCardnumber_4 = "K";
                    break;
            }

            for (int i = 0; i < cardNumber.Length; i++)     //  52장의 카드 생성
            {
                cardNumber[i] = i + 1;
            }
            cardMark = new string[4] { "♥", "♠", "◆", "♣" };        //  카드 문양

            cardNumber = cardNumber.OrderBy(x => random.Next()).ToArray();        //  카드 셔플

            int card_5 = cardNumber[0];
            string trumpCardmark_5 = cardMark[(card_5 - 1) / 13];
            string trumpCardnumber_5 = Math.Ceiling(card_5 % 13.1).ToString();

            switch (trumpCardnumber_5)
            {
                case "1":
                    trumpCardnumber_5 = "A";
                    break;
                case "11":
                    trumpCardnumber_5 = "J";
                    break;
                case "12":
                    trumpCardnumber_5 = "Q";
                    break;
                case "13":
                    trumpCardnumber_5 = "K";
                    break;
            }

            Console.WriteLine("┌────────┐   ┌────────┐   ┌────────┐   ┌────────┐   ┌────────┐");
            Console.WriteLine("│ {0}      │   │ {1}      │   │ {2}      │   │ {3}      │   │ {4}      │", trumpCardnumber_1, trumpCardnumber_2, trumpCardnumber_3, trumpCardnumber_4, trumpCardnumber_5);
            Console.WriteLine("│        │   │        │   │        │   │        │   │        │");
            Console.WriteLine("│        │   │        │   │        │   │        │   │        │");
            Console.WriteLine("│    {0}  │   │    {1}  │   │    {2}  │   │    {3}  │   │    {4}  │", trumpCardmark_1, trumpCardmark_2, trumpCardmark_3, trumpCardmark_4, trumpCardmark_5);
            Console.WriteLine("└────────┘   └────────┘   └────────┘   └────────┘   └────────┘");

        }       //  Main
    }
}