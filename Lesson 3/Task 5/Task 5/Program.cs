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
            Console.WriteLine("Список локальных максимумов: ");
            for (int i = 0; i < array.Length; i++)
            {
                
                Random rand = new Random();
                array[i] = rand.Next(0, 1000);
                if (i == 29 || i <= 0)
                { }
                else
                {
                    if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    {
                        Console.WriteLine(array[i] + ',');
                    }
                }
                //array[i] = array [i];
                //Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
