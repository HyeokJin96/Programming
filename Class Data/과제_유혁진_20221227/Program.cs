using System.Security.Cryptography.X509Certificates;

namespace 과제_유혁진_20221227
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SIZE_X = 3;
            const int SIZE_Y = 3;
            bool isGameOver = false;

            int[,] jail = new int[SIZE_Y, SIZE_X];
            int posX = SIZE_X / 2;
            int posY = SIZE_Y / 2;

            bool randomMode = false;
            int randomPerCent = 30;

            if (randomMode)
            {
                Random random = new Random();

                for (int y = 0; y < SIZE_Y; y++)
                {
                    for (int x = 0; x < SIZE_X; x++)
                    {
                        if (x == posX && y == posY)
                        {
                            jail[y, x] = 1;
                            continue;
                        }
                        if (random.Next(1, 100 + 1) < randomPerCent)
                        {
                            jail[y, x] = -1;
                        }
                        else
                        {
                            jail[y, x] = 0;
                        }
                    }
                }
            }
            else
            {
                for (int y = 0; y < SIZE_Y; y++)
                {
                    for (int x = 0; x < SIZE_X; x++)
                    {
                        if (x == 0 || x == SIZE_X - 1 ||
                            y == 0 || y == SIZE_Y - 1)
                        {
                            jail[y, x] = -1;
                        }
                        else if (x == posX && y == posY)
                        {
                            jail[y, x] = 1;
                        }
                        else
                        {
                            jail[y, x] = 0;
                        }
                    }
                }
            }
            while (isGameOver == false)
            {
                int oldPosX = posX;
                int oldPosY = posY;

                // { 상태 보여주기
                for (int y = 0; y < SIZE_Y; y++)
                {
                    for (int x = 0; x < SIZE_X; x++)
                    {
                        switch (jail[y, x])
                        {
                            case -1:
                                Console.Write("1".PadRight(2, ' '));
                                break;
                            case 0:
                                Console.Write("2".PadRight(3, ' '));
                                break;
                            case 1:
                                Console.Write("3".PadRight(2, ' '));
                                break;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Read();
                }
            }
        }
    }
}