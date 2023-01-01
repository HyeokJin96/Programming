using System;

namespace CHAPTER_01._최대한도의_사탕사기
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  LAB. 최대한도의 사탕사기

            //  * 철수가 가지고 있는 돈으로 최대한의 사탕을 사려고 한다.
            //  * 현재 1000원이 있고 사탕의 가격이 300원이라고 할 때 최대한 살 수 있는 사탕의 개수와 나머지 돈은 얼마인가?
            //  * 정수 나눗셈 연산자와 /와 나머지 연산자 %를 사용해보자.

            string name = "철수";
            int money = 1000;
            int candy_price = 300;

            int buy_number = money / candy_price;
            int change = money % candy_price;

            Console.WriteLine("{0}는 {1}개의 캔디를 사고 {2}원의 거스름돈을 받았다.", name, buy_number, change);
        }
    }
}