using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] map =
            {
            {'#','#','#','#','#','#','#','#','#','#','#','#' },
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            {'#',' ','X',' ',' ',' ',' ',' ',' ',' ','X','#' },
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
            {'#',' ',' ',' ',' ','X',' ',' ',' ',' ',' ','#' },
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ','X','#' },
            {'#','#','#','#','#','#','#','#','#','#','#','#' }
        };
            char[] bag = new char[0];


            int Y = 1, X = 1;
            while (true)
            {
                Console.SetCursorPosition(15, 0);
                Console.Write("Сумка:");

                for (int i = 0; i < bag.Length; i++)
                    Console.Write(bag[i] + " | ");

                Console.SetCursorPosition(0, 0);

                for (int row = 0; row < map.GetLength(0); row++)
                {
                    for (int col = 0; col < map.GetLength(1); col++)
                    {
                        Console.Write(map[row, col]);
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(Y, X);
                Console.Write('Y');

                ConsoleKeyInfo charKey = Console.ReadKey();
                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        X--;
                        break;
                    case ConsoleKey.DownArrow:
                        X++;
                        break;
                    case ConsoleKey.LeftArrow:
                        Y--;
                        break;
                    case ConsoleKey.RightArrow:
                        Y++;
                        break;
                }

                if (map[X, Y] == 'X')
                {
                    map[X, Y] = 'o';
                    char[] tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = 'X';
                    bag = tempBag;
                }
                Console.Clear();
            }
        }
    }
}
