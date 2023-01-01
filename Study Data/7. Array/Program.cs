using System;

namespace Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  1. 컬렉션

            //      * 이름 하나로 데이터 여러 개를 담을 수 있는 그릇을 컬렉션(collection)이라고 한다.
            //      * C#에서 다루는 컬레션은 배열(array), 리스트(list), 사전(dictionary)등이 있다.

            //  2. 배열

            //      * 배열(array)은 같은 종류의 데이터들이 순차적으로 메모리에 저장되는 자료 구조이다.
            //      * 각각의 데이터들은 인덱스(번호)를 사용하여 독립적으로 접근된다.
            //      * 배열을 이용하면 대용량의 데이터를 동일한 이름으로 쉽게 저장하고 처리할 수 있다.
            //      * 배열 사용의 장점
            //          1) 이름 하나로 변수 여러 개를 묶어 관리하기에 편하다.
            //          2) 반복문으로 쉽게 반복해서 값을 사용할 수 있다.
            //          3) 필요한 데이터 개수를 정확히 정한다면 메모리를 적게 사용하여 프로그램 크기가 작아지고 성능이 향상된다.
            //      * 배열은 데이터 형식 이름 뒤에 []기호를 사용하여 선언한다.
            //      * 배열에 저장된 데이터는 정수형 인덱스로 접근 가능하다.
            //      * 데이터형식[] 배열이름 = new 데이터형식[크기];   ->  int[] intArray = new int[3]
            //      * 배열에는 세 가지 종류가 있다.
            //          1) 1차원 배열 : 배열의 첨자를 하나만 사용하는 배열
            //          2) 2차원 배열 : 첨자 2개 이상을 사용하는 배열(2차원, 3차원, ...)
            //          3) 가변 배열 : '배열의 배열'이라고도 하며, 이름 하나로 다양한 차원의 배열을 표현

            //  3. 1차원 배열

            int[] numbers = new int[2] { 100, 200 };
            Console.WriteLine("{0}, {1}", numbers[0], numbers[1]);

            Console.WriteLine("------------------------------");

            string[] phones = new string[2] { "112", "119" };
            Console.WriteLine("{0}, {1}", phones[0], phones[1]);

            Console.WriteLine("------------------------------");

            int[] intArray = new int[3] { 1, 2, 3 };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i}번째 인덱스 : {intArray[i]}");
            }

            Console.WriteLine("------------------------------");

            //      * 선언과 동시에 초기화할 때는 new 키워드와 배열형([])까지 생략할 수 있다.
            int[] newArray = {1, 2, 3};

            //  4. 다차원 배열

            //      * 2차원 배열 및 3차원 배열처럼 차원이 2 이상인 배열을 다차원 배열이라고 한다.
            //      * C#에서 배열을 선언할 때는 콤마를 기준으로 차원을 구분한다.

            int[,] secondDimension = new int[2, 3];

            secondDimension[0, 0] = 1;
            secondDimension[0, 1] = 2;
            secondDimension[0, 2] = 3;
            secondDimension[1, 0] = 4;
            secondDimension[1, 1] = 5;
            secondDimension[1, 2] = 6;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{secondDimension[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------");

            //      * 2차원 배열 역시 선언과 동시에 초기화할 수 있다.
            //      * int[,] intArray = new int[,] { {1, 2, 3}, {4, 5, 6} };
            //      * int[,] intArray = { {1, 2, 3}, {4, 5, 6} };

            //  5. 가변 배열

            //      * 배열의 길이가 가변인 배열을 가변 배열이라고 한다.
            //      * 지그재그 형태의 배열이며, 데이터형식 [][] 배열이름; 형태로 사용한다.
        }
    }
}