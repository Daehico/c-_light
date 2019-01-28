using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array =  new int[3,3];
            Random rand = new Random();
            
             for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(1,10);
                    Console.Write(array[i, j] + "\t");
                }
            }
            int sum = array[1, 0] + array[1, 1] + array[1, 2];
            int multiplication = array[0, 0] * array[0, 1] * array[0, 2];

            Console.WriteLine("Сумма:" + sum);
            Console.WriteLine("Умножение" + multiplication);
            Console.ReadKey();
        }
    }
}
