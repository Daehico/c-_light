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
            int i = 7;

            Console.WriteLine("Добро пожаловать!");
            while (i <= 98)
            {
                Console.WriteLine(i);
                i += 7;
                
            }
            // While, потому что через цикл for у меня не получилось. Не ахти какой крутой ответ, но зато правда :)
            Console.WriteLine("Cпасибо за использование программы! Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}

