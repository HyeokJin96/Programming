using System;

namespace CHAPTER_01._화씨온도를_섭씨온도로_바꾸기
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  LAB. 화씨온도를 섭씨온도로 바꾸기

            //  * 우리나라는 섭씨 온도를 사용하지만 미국에서는 화씨 온도를 사용한다.
            //  * 화씨 온도를 섭씨 온도로 바꾸는 프로그램을 작성하여 보자.


            Console.WriteLine("온도를 입력하세요");

            double Fahrenheit_temp = Convert.ToDouble(Console.ReadLine());

            double Celsius_temp = (5.0 / 9.0) * (Fahrenheit_temp - 32);

            Console.WriteLine("{0}˚F 는 {1}˚C 입니다.", Fahrenheit_temp, Celsius_temp);
        }
    }
}