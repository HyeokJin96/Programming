using System;

namespace CHAPTER_02._숫자_맞추기_게임
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  LAB. 숫자 맞추기 게임

            //  * if 문과 do-while 문을 동시에 사용하는 예제를 작성
            //  * 1부터 100사이의 정수를 저장하고 있고 사용자는 질문을 통하여 그 정수를 알아맞히는 프로그램 작성
            //  * 사용자가 답을 제시하면 프로그램은 자신이 저장한 정수와 비교하여 제시된 정수가 더 높은지 낮은지를 알려줌 (HINT)
            //  * 프로그램은 사용하여 사용자가 정확하게 정수를 알아맞힐 때까지 반복
            //  * 사용자가 정답을 맞추면 몇 번 만에 알아맞혔는지를 화면에 출력
            //  * 사용자가 제시한 정수와 정답을 비교하는데 if 문을 사용

            Random rnadom = new Random();

            int answer = rnadom.Next(1, 100);       //  1부터 100사이의 랜덤한 정수값
            bool isGameOver = false;                //  프로그램 종료 조건
            int trynumber = 0;                      //  시도횟수

            do
            {
                Console.Write("1부터 100사이의 정수값을 맞춰보세요! : ");
                int myanswer = Convert.ToInt32(Console.ReadLine());
                trynumber++;

                if (myanswer == answer)
                {
                    Console.WriteLine("정답입니다!".PadRight(2));
                    Console.WriteLine($"{trynumber}번 시도하여 정답을 맞추셨습니다.");
                    break;
                }
                else if (myanswer < answer)
                {
                    Console.Write("틀렸습니다.\t");
                    Console.WriteLine("HIMT : {0}보다 큽니다.\n", myanswer);
                }
                else if (myanswer > answer)
                {
                    Console.Write("틀렸습니다.\t");
                    Console.WriteLine("HIMT : {0}보다 작습니다.\n", myanswer);
                }
            } while (isGameOver == false);
        }
    }
}