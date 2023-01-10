using System;

namespace CHAPTER02._Tic_Tac_Toe_게임
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  LAB. Tic-Tac-Toe 게임

            //  * Tic-Tac-Toe 게임은 2명의 경기자가 보드를 이용하여 번갈아가며 O와 X를 놓는 게임이다.
            //  * 같은 글자가 가로, 세로 혹은 대각선 상에 놓이면 이기게 된다.

            const int size_x = 3;
            const int size_y = 3;
            int[,] board = new int[size_y, size_x];

            for (int y = 0; y < size_y; y++)
            {
                for (int x = 0; x < size_x; x++)
                {
                    board[y, x] = board[size_y, size_x];
                }
                Console.WriteLine(board[size_y, size_x]);
            }
        }
    }
}