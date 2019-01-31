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
            bool tryParse;
            int value;
            while (true)
            {
                Console.Write("Введите число:");
               string userInput = Console.ReadLine();

                tryParse = Int32.TryParse(userInput, out value);
                if(tryParse == true)
                {
                    Console.WriteLine("Ваше число {0}",value);
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели не число");
                }
            }
            Console.ReadKey();

        }
    }
}
