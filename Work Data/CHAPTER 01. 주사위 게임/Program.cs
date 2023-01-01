using System;
using System.Collections;

namespace CHAPTER_01._주사위_게임
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  LAB. 주사위 게임

            //  * 2개의 주사위를 던져서 주사위의 합을 표시하는 프로그램을 작성
            //  * 주사위를 던지면 랜덤한 수가 나와야 한다.

            Random dice = new Random();
            int first_dice = dice.Next(1, 6);
            int second_dice = dice.Next(1, 6);

            int result = first_dice + second_dice;

            Console.WriteLine("첫 번째 주사위 : {0}", first_dice);
            Console.WriteLine("두 번째 주사위 : {0}", second_dice);
            Console.WriteLine("주사위의 합 : {0}", result);
        }
    }
}