using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            //	LAB 1. 3개의 정수 중에서 최대값을 찾는 함수 Maximum(x, y, z)를 정의

            //	LAB 2. 화면에 "Hello"를 출력하는 Sayheollo 함수를 작성
            //		* int 타입 매개변수 받아서 그 횟수만큼 "Hello"를 반복해서 출력

            //	LAB 3. 다른 두 변이 주어 졌을 때 직각 삼각형의 빗변을 계산하는 함수 (Hyport) 를 정의
            //		* 매개변수는 2개, 타입은 double형
            //		* 리턴 타입도 double형

            //	LAB 4. 주어진 숫자가 소수인지 여부를 찾는 함수 (Prime) 을 작성
            //		* 판별할 값의 범위는 2 ~ 100 사이의 값
            //		* 소수는 모두 출력

            //	LAB 5. 사용자가 입력하는 전화번호에서 소괄호를 삭제한 형태로 출력하는 프로그램을 작성
            //		* 전화번호를 입력 받아 소괄호를 삭제한 형태로 출력
            //		* quit 입력 시 프로그램 종료
            //		* 프로그램 종료 전까지 전화번호를 입력 받는다.

            SayHello("Hello", 5);

            double resultPow = Hyport(3, 4);

            Console.WriteLine(resultPow);

            Prime(2, 100);

        }

        static int FindMaxValue(int x, int y, int z)
        {

        }

        static void SayHello(string Hello, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0}", Hello);
            }
        }

        static double Hyport(double x, double y)
        {
            double Pow = Math.Pow(x, 2) + Math.Pow(y, 2);

            double Hyprt = Math.Sqrt(Pow);

            return Hyprt;
        }

        static int Prime(int number1, int number2)
        {
            for (number1 = 0; number1 < 100; number1++)
            {
                while (number1 > number2)
                {
                    if (number1 % number2 == 0)
                    {

                    }
                }
            }
        }

        static void DelteParemteres(string phoneNumber)
        {
            foreach (char charactor_ in phoneNumber)
            {
            }
            for (int index = 0; index < phoneNumberArray.Length; index++)
            {
                if (true)
                {

                }
            }
            Console.WriteLine();

            foreach (var item in collection)
            {
                if (true)
                {

                }
            }
        }
    }
}