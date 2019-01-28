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
            int[,] array = new int[10, 10];
            Random rand = new Random();
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(1, 15);
                    Console.Write(array[i, j] + "\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            int max = 0;
            int maxI = 0;
            int maxJ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {   
                    if (i != 0 && j != 0)
                    {
                        if (array[i, j] > max)
                        {
                            max = array[i, j];
                            maxI = i;
                            maxJ = j;
                        }
                    }

                }
               
                    }
            array[maxI, maxJ] = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
            }

                    Console.ReadKey();
        }
    }
}
