using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] map =
            {
            {'#','#','#','#','#','#','#','#','#','#','#','#' },
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ','+','#' },
            {'#','+','X','+',' ',' ',' ',' ',' ','+','X','#' },
            {'#',' ','+',' ',' ','+',' ',' ',' ',' ',' ','#' },
            {'#',' ',' ',' ','+','X',' ',' ',' ','+',' ','#' },
            {'#',' ',' ',' ',' ','+',' ',' ',' ','+','X','#' },
            {'#','#','#','#','#','#','#','#','#','#','#','#' }
        };

            char[] bag = new char[0];
            int health = 3;


            int Y = 1, X = 1;
            Console.WriteLine("Добро пожаловать! В это игре вам надо собрать все монетки, остерягаясь ловушек. \r\n(Монеты на карте обозначены Х, ловушки знаком +). " +
                "Каждое попадание персонажа на ловушку,\r\nуменьшает количество здоровья на одну единицу.\r\nУ вас всего три жизни. Цель игры собрать все монетки. Удачи!" +
                "\r\nНажмите любую клавишу что бы начать.");
            Console.ReadKey();
            Console.Clear();
            while (health != 0 && bag.Length !=4)
            {
                Console.SetCursorPosition(15, 0);
                Console.Write("Сумка:");
                Bag(bag);
                
                Console.SetCursorPosition(15, 1);
                Console.WriteLine("Здоровье:" + health);

               

                Console.SetCursorPosition(0, 0);


                Render(map);

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
                    Money(map, X, Y,bag);

                  
                   
                    
                }

                if (map[X, Y] == '#')
                {
                    Wall(X, Y);
                }

                if (map[X, Y] == '+')
                {
                    health -= 1;
                }

                if (bag.Length >= 4)
                {
                    break;
                }


                Console.Clear();
            }
            Console.Clear();
            WinOrLose(bag, health);
            Console.WriteLine("Спасибо за игру. Нажмите любую клавишу, что бы выйти");
            Console.ReadKey();
        }

        static void Render(char[,] map)
        {
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    Console.Write(map[row, col]);
                }
                Console.WriteLine();
            }
        }

        static void Move(int X, int Y)
        {
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
        }

        static void Wall(int  X, int Y)
        {
            if (X == 0 && Y > 0 && Y <= 14)
            {
                X++;
            }
            if (Y == 11 && X > 0 && X <= 6)
            {
                Y--;
            }
            if (X == 6 && Y > 0 && Y <= 14)
            {
                X--;
            }
            if (Y == 0 && X > 0 && X <= 6)
            {
                Y++;
            }
        }

        static char[] Money (char[,] map, int X,int Y, char[] bag)
        {
            map[X, Y] = 'o';
            char[] tempBag = new char[bag.Length + 1];
            for (int i = 0; i < bag.Length; i++)
            {
                tempBag[i] = bag[i];
            }
            tempBag[tempBag.Length - 1] = 'X';
            bag = tempBag;
            for (int i = 0; i < bag.Length; i++)
                Console.Write(bag[i] + " | ");
            return bag;
        }

        static void Bag(char[] bag)
        {
           
            for (int i = 0; i < bag.Length; i++)
            {
                Console.Write(bag[i]);
            }
        }

        static void WinOrLose(char[] bag, int health)
        {
            if (health <= 0)
            {
                Console.WriteLine("Вы погибли!");
            }
            if (bag.Length == 4)
                Console.WriteLine("Вы молодцы! Вы собрали все монеты");
        }

    }

   
}
