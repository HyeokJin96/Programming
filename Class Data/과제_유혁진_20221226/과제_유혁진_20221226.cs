using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            /* 5 X 5 보드
			 * 
			 * ■■■■■
			 * ■□□□■
			 * ■□읏□■
			 * ■□□□■
			 * ■■■■■
			 * 
			 * □은 빈 곳, ■는 벽을 의미
			 * 빈 곳중에 아무곳(정중앙)이나 사람을 초기화해서
			 * w, a, s, d 입력 받아서 빈 곳을 자유롭게 이동하는 프로그램 작성
			 *  - 사람은 빈 곳을 다닐 수 있음.
			 *  - 사람은 벽을 넘어다닐 수 없음.
			 */

            bool GameOver = false;

            string temp = "읏";

            string[,] stringArray = new string[5, 5];

            stringArray[0, 0] = "■";
            stringArray[0, 1] = "■";
            stringArray[0, 2] = "■";
            stringArray[0, 3] = "■";
            stringArray[0, 4] = "■";
            stringArray[1, 0] = "■";
            stringArray[1, 1] = "□";
            stringArray[1, 2] = "□";
            stringArray[1, 3] = "□";
            stringArray[1, 4] = "■";
            stringArray[2, 0] = "■";
            stringArray[2, 1] = "□";
            stringArray[2, 2] = "읏";
            stringArray[2, 3] = "□";
            stringArray[2, 4] = "■";
            stringArray[3, 0] = "■";
            stringArray[3, 1] = "□";
            stringArray[3, 2] = "□";
            stringArray[3, 3] = "□";
            stringArray[3, 4] = "■";
            stringArray[4, 0] = "■";
            stringArray[4, 1] = "■";
            stringArray[4, 2] = "■";
            stringArray[4, 3] = "■";
            stringArray[4, 4] = "■";

            while (GameOver == false)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0}", stringArray[0, i]);
                }
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0}", stringArray[1, i]);
                }
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0}", stringArray[2, i]);
                }
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0}", stringArray[3, i]);
                }
                Console.WriteLine();
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0}", stringArray[4, i]);
                }
                Console.WriteLine("\n");

                Console.WriteLine("방향키(w, a, s, d)를 사용해서 이동하세요\n");

                switch (Console.ReadLine())
                {
                    case "w":
                        Console.WriteLine("\n위로 한 칸 이동합니다.\n");
                        stringArray[2, 2] = stringArray[1, 2];
                        stringArray[1, 2] = temp;
                        break;

                    case "a":
                        Console.WriteLine("\n왼쪽으로 한 칸 이동합니다.\n");
                        stringArray[2, 2] = stringArray[2, 1];
                        stringArray[2, 1] = temp;
                        break;

                    case "s":
                        Console.WriteLine("\n아래로 한 칸 이동합니다.\n");
                        stringArray[2, 2] = stringArray[3, 2];
                        stringArray[3, 2] = temp;
                        break;

                    case "d":
                        Console.WriteLine("\n오른쪽으로 한 칸 이동합니다.\n");
                        stringArray[2, 2] = stringArray[2, 3];
                        stringArray[2, 3] = temp;
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }
            }
        }
    }
}