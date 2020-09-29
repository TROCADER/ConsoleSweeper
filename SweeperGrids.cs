using System;

namespace ConsoleSweeper
{
    public class SweeperGrids
    {
        public SweeperGrids()
        {
            int[,] board = new int[10, 10];

            for (int i = 0; i < board.GetLength(1); i++)
            {
                for (int i2 = 0; i2 < board.GetLength(0); i2++)
                {
                    board[i, i2] = 9;
                }
            }

            for (int i = 0; i < board.GetLength(1); i++)
            {
                for (int i2 = 0; i2 < board.GetLength(0); i2++)
                {
                    Console.Write(board[i, i2]);
                }
                Console.WriteLine();
            }
        }
    }
}
