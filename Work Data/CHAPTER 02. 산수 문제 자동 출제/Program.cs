using System;

namespace CHAPTER_02._산수_문제_자동_출제
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  LAB. 산수 문제 자동 출제

            //  * 초등학교 학생들을 위한 산수 문제를 자동으로 출제하는 프로그램을 작성
            //  * 덧셈 문제들을 자동으로 생성
            //  * 피연산자는 0에서 99사이의 숫자의 난수
            //  * 한번이라도 맞으면 종료

            Random random = new Random();


            bool isGameOver = false;        //  루프 종료 조건

            Console.WriteLine("다음 문제를 풀어보세요!");

            while (isGameOver == false)
            {
                int firstNumber = random.Next(0, 99);       //  첫 번째 난수
                int secondNumber = random.Next(0, 99);      //  두 번째 난수

                Console.Write($"{firstNumber} + {secondNumber} = ");
                int answer = Convert.ToInt32(Console.ReadLine());

                if (firstNumber + secondNumber == answer)
                {
                    Console.WriteLine("정답입니다.");
                    isGameOver = true;
                }
                else
                {
                    Console.WriteLine("오답입니다. 다시 풀어보세요.\n");
                }
            }
        }
    }
}