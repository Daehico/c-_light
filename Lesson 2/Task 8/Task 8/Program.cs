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
            Console.Write("Добро пожаловать в программу! Введите пароль, если он совпадет, то вы узнаете секрет! У вас 5 попыток.");
            string ourPassword = "12345";
            string userPassword;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите пароль");
                userPassword = Console.ReadLine();
                if (userPassword == ourPassword)
                {
                    Console.WriteLine("Секрет расскрыт!");
                    break;
                }
                int _try = i;
                string trys = _try++.ToString();
                Console.WriteLine("Это ваша {0} попытка", trys);

            }
            Console.WriteLine("Спасибо за использование программы! Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
