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
            int[] array1 = new int[1];
            int[] array2 = new int[1];

            int _int = 0;
           
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
                        i++;
                        array2 = new int[i];

                    }
                    else
                    {
                       
                        array2[i-1] = array1[i-1];
                        array1 = new int[i+1];
                        for (int j = 0; j < array2.Length; j++ ){
                            array1[j] = array2[j];
                        }
                        array1[i+1] = _int;
                        i++;
                        array2 = new int[i];
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не число");
                }
                
            }
        }
    }
}
