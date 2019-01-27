using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[8] { 5, 8, 10, 5, 4, 6, 7, 9 };
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < table.Length; i++)
                {
                    Console.Write("| " + i + " - " + table[i] + " ");
                }

                Console.Write("\nЗа каким столом вы хотите бронь?: ");
                int bron = Convert.ToInt32(Console.ReadLine());

                if (table[bron] == 0)
                {
                    Console.Write("Вам настолько нравится наше кафе, что вы принесете с собой стулья?");
                    string _newTables = Console.ReadLine();
                    if (_newTables.ToLower() == "да")
                    {
                        Random rand = new Random();
                        int _random = rand.Next(0, 9);
                        Console.WriteLine("Тогда можете подсесть к столику" + _random);
                    }
                    else
                    {
                        Console.WriteLine("Мест нет(");
                        continue;
                    }

                }

                Console.Write("Сколько мест вам нужно?: ");
                int place = Convert.ToInt32(Console.ReadLine());

                if (table[bron] >= place && place > 0)
                {
                    table[bron] -= place;
                }
                else { Console.WriteLine("Недостаточно мест."); }

                Console.Write("Вы поели?");
                string eat = Console.ReadLine();
                if (eat.ToLower() == "да")
                {
                    Console.Write("За каким столом вы сидели?");
                    bron = Convert.ToInt32(Console.ReadLine());
                    table[bron] = bron;
                    Console.WriteLine("Столик № " + table[bron] + "свободен");
                }

                Console.ReadKey();
            }
        }
    }
}