using System;

namespace ConsoleSweeper
{
    public class SweeperGrids
    {
        private Random random = new Random();
        
        private int[,] board = new int[10, 10];
        private bool success = false;
        private int playerChooseInt;
        private int playerChooseInt2;
        
        public SweeperGrids()
        {
            for (int i = 0; i < board.GetLength(1); i++)
            {
                for (int i2 = 0; i2 < board.GetLength(0); i2++)
                {
                    board[i, i2] = 9;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                board[random.Next(board.GetLength(1)), random.Next(board.GetLength(0))] = 10;
            }

            for (int i = 0; i < board.GetLength(1); i++)
            {
                for (int i2 = 0; i2 < board.GetLength(0); i2++)
                {
                    Console.Write(board[i, i2]+" ");
                }

                Console.WriteLine();
            }
        }

        public void CheckPosition()
        {
            string playerChoose = Console.ReadLine();
            success = int.TryParse(playerChoose, out playerChooseInt);

            string playerChoose2 = Console.ReadLine();
            success = int.TryParse(playerChoose2, out playerChooseInt2);

            int[] tempArray = {playerChooseInt, playerChooseInt2};

            if (board[playerChooseInt, playerChooseInt2] == 10)
            {
                System.Console.WriteLine("works");
            }

            //Debug-kod
            Console.WriteLine(board[playerChooseInt, playerChooseInt2]);
        }
    }
}
