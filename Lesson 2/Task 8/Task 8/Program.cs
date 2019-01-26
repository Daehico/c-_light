using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу! Введите пароль, если он совпадет, то вы узнаете секрет! У вас 5 попыток.");
            string ourPassword = "12345";
            string userPassword;
            for (int i = 0; i < 5; i++)
            {
                int _try = i;
                int trys = _try+ 1;
                Console.Write("Введите пароль:");
                userPassword = Console.ReadLine();
                if (userPassword == ourPassword)
                {
                    Console.WriteLine("Секрет расскрыт!");
                    break;
                }
               
                Console.WriteLine("Это ваша {0} попытка", trys.ToString());

            }
            Console.WriteLine("Спасибо за использование программы! Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
