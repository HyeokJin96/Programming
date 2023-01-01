using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            // 1~100의 숫자 중에서 3의 배수이면서 4의 배수인 정수 합 구하기

            int threeFour = 0;
            for (int i = 1; i <= 100; i++)
            {
                if(i%3 == 0 && i%4 == 0)
                {
                    threeFour += i;
                }
            }
            Console.WriteLine($"1~100까지의 숫자 중 3의 배수이며 4의 배수인 정수 합 : {threeFour} \n");

            // 두 개의 정수를 입력 받아서 두 수의 차를 출력하는 프로그램
            // 항상 큰 수에서 작은 수를 뺀 결과를 출력할 것
            // 결과는 언제나 0 이상이어야 함


            int Num1 = 0;
            int Num2 = 0;
            int sub = 0;
            while(Num1 == Num2)
            {
                Console.Write("첫번째 정수를 입력해주세요. -> ");
                int.TryParse(Console.ReadLine(), out Num1);

                Console.Write("두번째 정수를 첫번째 정수와 다르게 입력해주세요. -> ");
                int.TryParse(Console.ReadLine(), out Num2);

            }
            if(Num1 > Num2)
                sub = Num1 - Num2;
            else
                sub = Num2 - Num1;
            Console.WriteLine($"두 수의 차이는 {sub}입니다. \n" );


            // 구구단을 출력하되 짝수만 출력
            // 2단은 2x2까지 4단은 4x4까지 ... 8단은 8x8까지만 출력
            // break와 continue를 사용

            for (int i = 1; i <= 9; i++)
            {
                if(i%2 == 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"{j} x {i} = {j*i} ");
                    }
                    Console.WriteLine();
                }
            }

            // 다음 식을 만족하는 모든 A와 Z를 구하는 프로그램을 작성

            /**
             *      A Z
             *  +   Z A
             *  ________
             *      9 9
             */

            int A = 0; 
            int Z = 0;
            string AZ = "";
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (i+j == 9)
                    {
                        A = i;
                        Z = j;
                        if (AZ != "")
                            AZ = AZ + ", [" + A + " " + Z + "]";
                        else
                            AZ = "[" + A + " " + Z + "]";
                    }
                }
                
            }
            Console.WriteLine("다음 식을 만족하는 모든 A와 Z를 구하시오 \n");
            Console.WriteLine("A Z".PadLeft(7));
            Console.WriteLine("+"+"Z A".PadLeft(6));
            Console.WriteLine("_________");
            Console.WriteLine("9 9".PadLeft(7)+"\n");
            Console.WriteLine("A와 Z의 조합 : "+AZ);

        }
    }
}
