using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            int i = 0;
            int j = 1;
            int[] array1 = new int[j];
            int[] array2 = new int[j];
            

            int _int;
            Console.WriteLine("Данная программа посчитает сумму введенных вами чисел. \n\rВводите числа,а для того что бы посчитать их сумму введите коману sum");
            while (command.ToLower() != "sum")
            {
                Console.Write("Введите число:");
                command = Console.ReadLine();
                bool _TryParse = Int32.TryParse( command ,out _int);
                if (_TryParse)
                {
                   if (i == 0)
                    {
                       
                        array1[i] = _int;
                     
                        

                    }
                    else
                    {
                        array2 = new int[j++];
                        Array.Copy(array1,array2, j-1);
                        array1 = new int[j];
                        Array.Copy(array2, array1 = new int[j], j-1);

                        array1[i] = _int;
                        
                        
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не число");
                }
                i++;
            }
            int sum = 0;
            if (array1.Length > array2.Length)
            {
                for (int e = 0; e < array1.Length; e++)
                {
                    sum += array1[e];
                }
            }
            else
            {
                for (int e = 0; e < array2.Length; e++)
                {
                    sum += array2[e];
                }
                
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
