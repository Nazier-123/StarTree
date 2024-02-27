using System;

namespace StarTree
{
    class Program
    {
        static int rows;
        static string rowsStr;
        static void Main(string[] args)
        {
            Console.WriteLine("How many rows do you want? ");
            rowsStr = Console.ReadLine();
            rows = int.Parse(rowsStr);
            Tree();
        }

        private static void Tree() 
        {
            for (int x = 0; x < rows; x++)
            {
                int spaces = rows - x - 1;
                int stars = 2 * x + 1;

                for(int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y < stars; y++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
