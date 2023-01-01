using System;
using System.Xml.Schema;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SIZE_X = 9;
            const int SIZE_Y = 9;

            int[,] BoardSize = new int[SIZE_X, SIZE_Y];
            int Board_x = SIZE_X / 2;
            int Board_y = SIZE_Y / 2;
            int newBoard_x = Board_x;
            int newBoard_y = Board_y;
            int number = 3;

            bool GameOver = false;

            Random coin = new Random();

            int random_X = coin.Next(1, 8);
            int random_Y = coin.Next(1, 8);

            while (GameOver == false)
            {
                Console.WriteLine("====================================");
                Console.WriteLine("   코  인  을  획  득  하  세  요");
                Console.WriteLine("====================================\n");

                for (int x = 0; x < SIZE_X; x++)
                {
                    for (int y = 0; y < SIZE_Y; y++)
                    {
                        if (x == 0 || x == SIZE_X - 1 || y == 0 || y == SIZE_Y - 1)
                        {
                            BoardSize[x, y] = -1;
                        }
                        else if (x == Board_x && y == Board_y)
                        {
                            BoardSize[x, y] = 1;
                        }
                        else
                        {
                            BoardSize[x, y] = 0;
                        }
                    }
                }
                // { 코인을 랜덤한 위치에 설정해 주는 코드
                if (BoardSize[Board_x, Board_y] != BoardSize[random_X, random_Y])
                {
                    BoardSize[random_X, random_Y] = 2;

                    Console.WriteLine("        ┌──────────────────┐");
                    Console.WriteLine("        │ 남은 코인 수 : {0} │", number);
                    Console.WriteLine("        └──────────────────┘");

                }
                else
                {
                    number--;

                    random_X = coin.Next(1, 8);
                    random_Y = coin.Next(1, 8);
                    BoardSize[random_X, random_Y] = 2;
                }
                if (number == 0)
                {
                    GameOver = true;

                    Console.WriteLine("====================================");
                    Console.WriteLine("   G   A   M   E");
                    Console.WriteLine("                O   V   E   R");
                    Console.WriteLine("====================================");

                    break;
                }       // if: 여기서 게임종료


                for (int x = 0; x < SIZE_X; x++)
                {
                    for (int y = 0; y < SIZE_Y; y++)
                    {
                        switch (BoardSize[x, y])
                        {
                            case -1:
                                Console.Write("  ■".PadRight(2));
                                break;
                            case 0:
                                Console.Write("  □".PadRight(2));
                                break;
                            case 1:
                                Console.Write("  읏".PadRight(2));
                                break;
                            case 2:
                                Console.Write("  ⓒ".PadRight(2));
                                break;
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\n이동키 w, a, s, d 를 입력해서 이동하세요 \n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "w":
                        Console.WriteLine("\n위로 한 칸 이동합니다");
                        Board_x = Board_x - 1;
                        break;
                    case "a":
                        Console.WriteLine("\n왼쪽으로 한 칸 이동합니다.");
                        Board_y = Board_y - 1;
                        break;
                    case "s":
                        Console.WriteLine("\n아래로 한 칸 이동합니다.");
                        Board_x = Board_x + 1;
                        break;
                    case "d":
                        Console.WriteLine("\n오른쪽으로 한 칸 이동합니다.");
                        Board_y = Board_y + 1;
                        break;
                    default:
                        Console.WriteLine("\n잘못된 입력입니다. 다시 입력해주세요.");
                        break;
                }

                if (BoardSize[Board_x, Board_y] == -1)
                {
                    Board_x = newBoard_x;
                    Board_y = newBoard_y;

                    Console.WriteLine("\n벽 밖으로 나갈 수 없습니다. 시작점으로 돌아갑니다.");
                }
            }
        }       // Main

        public void Coin()
        {

        }
    }   //  class    
}