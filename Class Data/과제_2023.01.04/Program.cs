using System;
using System.Security.Cryptography.X509Certificates;

namespace 과제_2023._01._04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program BoardGame = new Program();
            BoardGame.Test();

        }       // Main

        const int SIZE_X = 11;
        const int SIZE_Y = 11;
        const int newSIZE_X = 11;
        const int newSIZE_Y = 11;

        int[,] BoardSize = new int[SIZE_X, SIZE_Y];
        int[,] newBoardSize = new int[newSIZE_X, newSIZE_Y];
        int Board_x = SIZE_X / 2;
        int Board_y = SIZE_Y / 2;
        int newBoard_x;
        int newBoard_y;

        public void CreateBoard()
        {
            Console.Clear();
            for (int y = 0; y < SIZE_Y; y++)
            {
                for (int x = 0; x < SIZE_X; x++)
                {
                    if (x == 0 || y == 0)
                    {
                        BoardSize[y, x] = -1;
                    }
                    else if (x == SIZE_X - 1 && (y! < 4 || y! > 6))
                    {
                        BoardSize[y, x] = -1;
                    }
                    else if (y == SIZE_Y - 1 && (x! < 4 || x! > 6))
                    {
                        BoardSize[y, x] = -1;
                    }
                    else if (x == SIZE_X - 1 && (y > 4 || y < 6))
                    {
                        BoardSize[y, x] = 2;
                    }
                    else if (y == SIZE_Y - 1 && (x > 4 || x < 6))
                    {
                        BoardSize[y, x] = 3;
                    }
                    else if (x == Board_x && y == Board_y)
                    {
                        BoardSize[y, x] = 1;
                    }
                    else
                    {
                        BoardSize[y, x] = 0;
                    }
                }
            }
            for (int y = 0; y < SIZE_Y; y++)
            {
                for (int x = 0; x < SIZE_X; x++)
                {
                    switch (BoardSize[y, x])
                    {
                        case -1:
                            Console.Write("■".PadRight(2));
                            break;
                        case 1:
                            Console.Write("★".PadRight(2));
                            break;
                        case 0:
                            Console.Write("□".PadRight(2));
                            break;
                        case 2:
                            Console.Write("↔".PadRight(2));
                            break;
                        case 3:
                            Console.Write("↕".PadRight(2));
                            break;
                        default:
                            break;

                    }
                }
                Console.WriteLine();
            }
        }       //  CreateBoard ()

        public void Action()
        {
            Console.Write("\n방향키 \'w\', \'a\', \'s\', \'d\'를 이용해서 움직이세요! : ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "w":
                    Console.WriteLine("\'w\'를 입력하셨습니다. 위로 이동합니다.");
                    if (Board_y !> 1)
                    {
                        Board_y = Board_y - 1;
                    }
                    else
                    {
                        Console.WriteLine("[ERROR] 벽을 통과할 수 없습니다.");
                    }
                    break;
                case "a":
                    Console.WriteLine("\'a\'를 입력하셨습니다. 왼쪽으로로 이동합니다.");
                    if (Board_x !> 1)
                    {
                        Board_x = Board_x - 1;
                    }
                    else
                    {
                        Console.WriteLine("[ERROR] 벽을 통과할 수 없습니다.");
                    }
                    break;
                case "s":
                    Console.WriteLine("\'s\'를 입력하셨습니다. 아래로 이동합니다.");
                    if (Board_y !< 9)
                    {
                        Board_y = Board_y + 1;
                    }
                    else if (Board_y == 9 && (Board_x > 3 && Board_x < 7))
                    {
                        Console.WriteLine("이동");
                        Board_y = Board_y + 1;
                    }
                    else
                    {
                        Console.WriteLine("[ERROR] 벽을 통과할 수 없습니다.");
                    }
                    break;
                case "d":
                    Console.WriteLine("\'d\'를 입력하셨습니다. 오른쪽으로 이동합니다.");
                    if (Board_x! < 9)
                    {
                        Board_x = Board_x + 1;
                    }
                    else
                    {
                        Console.WriteLine("[ERROR] 벽을 통과할 수 없습니다.");
                    }
                    break;
                default:
                    Console.WriteLine("[ERROR] 잘못된 입력입니다.");
                    break;
            }
        }       //  Action ()

        public void CreateNewBoard()
        {
            Console.WriteLine();
            Console.Clear();
            for (int y = 0; y < newSIZE_Y; y++)
            {
                for (int x = 0; x < newSIZE_X; x++)
                {
                    if (x == 0 || y == newSIZE_Y - 1)
                    {
                        newBoardSize[y, x] = -1;
                    }
                    else if (x == newSIZE_X - 1 && (y! < 4 || y! > 6))
                    {
                        newBoardSize[y, x] = -1;
                    }
                    else if (y == 0 && (x! < 4 || x! > 6))
                    {
                        newBoardSize[y, x] = -1;
                    }
                    else if (x == newSIZE_X - 1 && (y > 4 || y < 6))
                    {
                        newBoardSize[y, x] = 2;
                    }
                    else if (y == 0 && (x > 4 || x < 6))
                    {
                        newBoardSize[y, x] = 3;
                    }
                    else if (x == newBoard_x && y == newBoard_y)
                    {
                        newBoardSize[y, x] = 1;
                    }
                    else
                    {
                        newBoardSize[y, x] = 0;
                    }
                }
            }
            for (int y = 0; y < newSIZE_Y; y++)
            {
                for (int x = 0; x < newSIZE_X; x++)
                {
                    switch (newBoardSize[y, x])
                    {
                        case -1:
                            Console.Write("■".PadRight(2));
                            break;
                        case 1:
                            Console.Write("★".PadRight(2));
                            break;
                        case 0:
                            Console.Write("□".PadRight(2));
                            break;
                        case 2:
                            Console.Write("↔".PadRight(2));
                            break;
                        case 3:
                            Console.Write("↕".PadRight(2));
                            break;
                        default:
                            break;

                    }
                }
                Console.WriteLine("");
            }
        }       //  CreatNewBoard ()

        public void newAction()
        {
            Console.Write("\n방향키 \'w\', \'a\', \'s\', \'d\'를 이용해서 움직이세요! : ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "w":
                    Console.WriteLine("\'w\'를 입력하셨습니다. 위로 이동합니다.");
                    if (newBoard_y !> 1)
                    {
                        newBoard_y = newBoard_y - 1;
                    }
                    else if (newBoard_y == 1 && (newBoard_x > 3 && newBoard_x < 7))
                    {
                        Console.WriteLine("이동");
                        newBoard_y = newBoard_y + 1;
                    }
                    else
                    {
                        Console.WriteLine("[ERROR] 벽을 통과할 수 없습니다.");
                    }
                    break;
                case "a":
                    Console.WriteLine("\'a\'를 입력하셨습니다. 왼쪽으로로 이동합니다.");
                    if (newBoard_x !> 1)
                    {
                        newBoard_x = newBoard_x - 1;
                    }
                    else
                    {
                        Console.WriteLine("[ERROR] 벽을 통과할 수 없습니다.");
                    }
                    break;
                case "s":
                    Console.WriteLine("\'s\'를 입력하셨습니다. 아래로 이동합니다.");
                    if (newBoard_y !< 9)
                    {
                        newBoard_y = newBoard_y + 1;
                    }
                    else
                    {
                        Console.WriteLine("[ERROR] 벽을 통과할 수 없습니다.");
                    }
                    break;
                case "d":
                    Console.WriteLine("\'d\'를 입력하셨습니다. 오른쪽으로 이동합니다.");
                    if (newBoard_x !< 9)
                    {
                        newBoard_x = newBoard_x + 1;
                    }
                    else
                    {
                        Console.WriteLine("[ERROR] 벽을 통과할 수 없습니다.");
                    }
                    break;
                default:
                    Console.WriteLine("[ERROR] 잘못된 입력입니다.");
                    break;
            }
        }


        public void Portal()
        {


        }


        public void Test()
        {
            bool isGameOver = false;

            while (isGameOver == false)
            {
                if (Board_y == 10 && (Board_x > 3 && Board_x < 7))
                {
                    newBoard_y = 1;
                    newBoard_x = Board_x;
                    CreateNewBoard();
                    newAction();
                }
                else
                {
                    CreateBoard();
                    Action();
                }

                if (newBoard_y == 1 && (newBoard_x > 3 && newBoard_x < 7))
                {
                    Board_y = 9;
                    Board_x = newBoard_x;
                    CreateNewBoard();
                    newAction();
                }
                else
                {
                    CreateNewBoard();
                    newAction();
                }
            }
        }
    }
}