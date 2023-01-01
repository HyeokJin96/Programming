using System;

namespace CHAPTER_02._세_개의_정수_중에서_큰_수_찾기
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  LAB. 세 개의 정수 중에서 큰 수 찾기

            //  * 사용자로부터 받은 3개의 정수 중에서 가장 큰 수를 찾는 프로그램 작성

            Console.Write("첫 번째 정수를 입력하세요 : ");
            int input_A = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번째 정수를 입력하세요 : ");
            int input_B = Convert.ToInt32(Console.ReadLine());
            Console.Write("세 번째 정수를 입력하세요 : ");
            int input_C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (input_A > input_B && input_A > input_C)
            {
                Console.WriteLine("세 가지 정수 중 가장 큰 정수는 {0}입니다.", input_A);
            }
            else if (input_B > input_A && input_B > input_C)
            {
                Console.WriteLine("세 가지 정수 중 가장 큰 정수는 {0}입니다.", input_B);
            }
            else
            {
                Console.WriteLine("세 가지 정수 중 가장 큰 정수는 {0}입니다.", input_C);
            }
        }
    }
}