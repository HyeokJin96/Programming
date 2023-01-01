using System;

namespace Control_statement
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  * 제어문(control statement)은 프로그램 실행 순서를 제어하거나 프로그램 내용을 반복하는 작업 등을 처리할 때 사용하는 구문으로 조건문과 반복문으로 구분한다.

            //  1. 순차문

            //      * 기본적으로 모든 실행문은 순서대로 실행된다.

            int kor = 100;
            int eng = 90;

            int total = kor + eng;
            double avg = total / 2;

            Console.WriteLine("총점 : {0}", total);
            Console.WriteLine("평균 : {0}", avg);

            Console.WriteLine("------------------------------");

            //      * 순서대로 변수를 선언하고, 총점과 평균을 구하고, 그 값을 출력하는 형태로 실행 -> 이처럼 프로그램은 기본적으로 Main() 메서드에서 순서대로 실행한다.

            //  2. 조건문(if-else 문)

            //      * 조건의 참 또는 거짓에 따라 서로 다른 명령문을 실행할 수 있는 구조로 분기문 또는 비교 판단문이라고도 한다.
            //      * 프로그램 흐름을 여러 가지 갈래로 가지치기(branching)할 수 있는데, 이때 if 문을 사용한다.
            //      * if문은 조건을 비교해서 판단하는 구문으로 if, else, else if 세 가지 키워드가 있다.
            //      * else 문은 단독으로 사용할 수 없고 if문 다음에 else문이 오는 구조이다.
            //      * else 문을 사용하면 if 문 조건이 거짓일 때 원하는 실행문을 실행할 수 있어 두 방향으로 분기하는 구조를 만들 수 있다.

            int score = 60;

            if (score >= 60)
            {
                Console.WriteLine("합격");
            }

            Console.WriteLine("------------------------------");

            Console.WriteLine("x값을 입력하세요");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y값을 입력하세요");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("x가 y보다 큽니다.");
            }
            else if (x == y)
            {
                Console.WriteLine("x와 y가 같습니다.");
            }
            else
            {
                Console.WriteLine("y가 x보다 큽니다.");
            }

            Console.WriteLine("------------------------------");

            //  3. 조건문(switch 문)

            //      * switch 문은 여러 개의 가능한 실행 경로 중에서 하나를 선택하는데 사용된다.
            //      * switch 문은 switch 안에 들어 있는 수식을 계산해서 case 레이블과 비교하여 일치하는 case 절이 있으면 case 레이블의 문장들이 실행되다가 break 문에 도달하면 종료된다.
            //        만약 case 레이블에서 일치하는 값을 찾지 못하면 최종적으로 default 절이 실행되며, default 레이블은 생략 가능하다.

            int number = 2;

            switch (number)
            {
                case 0:
                    Console.WriteLine("0 입니다.");
                    break;
                case 1:
                    Console.WriteLine("1 입니다.");
                    break;
                case 2:
                    Console.WriteLine("2 입니다.");
                    break;
            }

            Console.WriteLine("정수를 입력하세요");

            int answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    Console.WriteLine("1을 선택했습니다.");
                    break;
                case 2:
                    Console.WriteLine("2를 선택했습니다.");
                    break;
                case 3:
                    Console.WriteLine("3을 선택했습니다.");
                    break;
                default:
                    Console.WriteLine("4이상의 정수를 선택했습니다.");
                    break;
            }

            Console.WriteLine("------------------------------");

            //  4. 반복문(for 문)

            //      * 특정 명령문을 지정된 수만큼 반복해서 실행할 때나 조건식이 참일 동안 반복시킬 때 사용한다.
            //      * for 문은 특정 구문을 여러 번 반복해서 실행할 때 사용하며, for 문을 지칭할 때 for 루프(loop)라고도 한다.
            //      * for (초기식 ; 조건식 ; 증감식) { 문장 }
            //      * 초기식은 반복에 사용되는 변수를 선언하거나 초기화하며, 반복이 시작될 때 딱 한번 실행된다.
            //      * 만약 조건식이 참이면 문장을 실행하며, 거짓으로 계산되면 반복은 종료하게 된다.
            //      * 증감식은 한 번의 반복 뒤에 실행되며, 제어 변수를 증가하거나 감소하게 된다.

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("3번 반복한다.");
            }

            Console.WriteLine("------------------------------");

            int sum = 0;

            for (int i = 1; i < 11; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("1 부터 10까지의 합 : {0}", sum);

            Console.WriteLine("------------------------------");

            int factorial = 0;

            for (int i = 1; i < 5; i++)
            {
                Console.Write($"{i}! = ");

                factorial = 1;

                for (int j = 1; j <= i; j++)
                {
                    factorial = factorial * j;
                }
                Console.WriteLine($"{factorial, 2}");
            }

            Console.WriteLine("------------------------------");

            for (int i = 1; i < 10; i++)
            {
                Console.Write($"{i, 4}단   ");
            }
            Console.WriteLine();

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($" {j}*{i}={j * i, 2}  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------");

            //  5. 반복문(while 문, do 문, foreach 문)

            //      * for 문(구간 반복)과 마찬가지로 반복을 처리하는 while 문(조건 반복), do(실행 반복), foreach(배열 반복)을 다룬다.
            //      * while 문은 조건식이 참일 동안 실행문을 반복하여 실행하며, 반복을 중지하려면 while 문 안쪽 코드에서 증감식 등을 사용하여 조건식 값을 변경하여야 한다.

            int count = 0;

            while (count < 3)
            {
                Console.WriteLine("count 값이 3보다 작을 경우 반복");
                count++;
            }

            Console.WriteLine("------------------------------");

            int newCount = 1;

            while (newCount <= 3)
            {
                Console.WriteLine($"카운트 : {newCount}");
                newCount++;
            }

            Console.WriteLine("------------------------------");

            //      * do-while 문은 while 문과 비슷하지만, 일단 문장을 한 번 실행한 후 그다음에 조건을 따지는 구문이다.
            //      * do 문은 while(조건식)이 뒤에 오므로 무조건 한 번은 실행문이 실행된다.

            int doCount = 0;

            do
            {
                Console.WriteLine("무조건 한 번은 출력된다");
                doCount++;
            } while (doCount < 3);

            Console.WriteLine("------------------------------");

            //      * foreach 문은 배열(array)이나 컬렉션(collection) 같은 값을 여러 개 담고 있는 데이터 구조에서 각가의 데이터가 들어 있는 만큼 반복하는 구조이다.
            //      * foreach 문은 반복 가능한 항목들을 반복해서 가져온다.
            //      * foreach (항목 in 항목들) { ... }

            string[] names = { "C#", "ASP.NET" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("------------------------------");

            string str = "ABC123";

            foreach (char world in str)
            {
                Console.Write($"{world}\t");
            }

            //  6. break 문

            //      * 반복문 내에서 반복을 중지한다.
            //      * break 문은 반복문과 switch 문을 빠져나가는 역할을 한다.

            //  7. continue 문

            //      * 반복문 내에서 그다음 반복문으로 이동한다.
            //      * continue 문은 반복문의 나머지 코드를 실행하지 않고 반복문 다음 처리영역으로 넘어간다.

            //  8. goto 문

            //      * C#에서 자주 사용하지 않지만, 레이블로 지정된 곳으로 직접 이동시킨다.
            //      * goto 문은 특정 레이블로 지정된 영역으로 이동한다.
        }
    }
}