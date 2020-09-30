using System;

namespace ConsoleSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            SweeperGrids sweeperGrids = new SweeperGrids();

            sweeperGrids.CheckPosition();
            
            Console.ReadLine();
        }
    }
}
