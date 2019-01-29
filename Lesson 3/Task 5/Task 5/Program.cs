using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[30];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 50);
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Список локальных максимумов: ");
            for (int i = 0; i < array.Length; i++) {
                if (i == 29 || i <= 0)
                { }
                else
                {
                    if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
