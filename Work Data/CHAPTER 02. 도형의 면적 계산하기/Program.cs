using System;

namespace CHAPTER_02._도형의_면적_계산하기
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  LAB. 도형의 면적 계산하기

            //  * 여러 가지 도형의 면적을 계산하는 프로그램을 작성
            //  * 사용자에게 도형을 선택하라고 요청한 후, 사용자의 입력을 기다리고 이를 처리하기 위해 if-else 블록을 사용
            //  * 사용자가 유효한 선택 사항을 입력하면 프로그램은 지정된 모양의 면적을 계산한다. 그렇지 않은 경우 유효하지 않음을 사용자에게 알린다.

            Console.WriteLine("도형을 선택하세요 : \t 삼각형 : 1 \t 사각형 : 2 \t 원 : 3");
            Console.Write("입력을 기다리는 중 ... : ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            {
                Console.Write("밑변 : ");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.Write("높이 : ");
                int length = Convert.ToInt32(Console.ReadLine());

                int area = (width * length) / 2;
                Console.Write("면적 : {0}", area);
            }
            else if (userInput == 2)
            {
                Console.Write("가로 : ");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.Write("세로 : ");
                int length = Convert.ToInt32(Console.ReadLine());

                int area = width * length;
                Console.Write("면적 : {0}", area);
            }
            else if (userInput == 3)
            {
                Console.Write("반지름 : ");
                int radius = Convert.ToInt32(Console.ReadLine());

                double area = Math.Pow(radius, 2) * Math.PI;
                Console.Write("면적 : {0}", area);
            }
            else
            {
                Console.WriteLine("ERROR : 잘못된 입력입니다.");
            }
        }
    }
}