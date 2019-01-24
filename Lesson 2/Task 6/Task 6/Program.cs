using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу! Отгадайте загадку");
            string answer = "";

            for (int i = 0; i<3; i++)
            {
                int _try = i;
                int trys = 3 - (_try + 1);
                Console.Write("Введите ваш ответ ");
                answer = Console.ReadLine();
                if (answer == "троллейбус.")
                {
                    Console.WriteLine("И это правильный ответ!");
                    break;
                }
                else if (answer == "Сдаюсь")
                {
                    Console.WriteLine("Фуфуфу сдаваться. Правильный ответ троллейбус.");
                    break;
                }
                else
                {
                 
                    Console.WriteLine("Ответ не правильный. Попробуйте еще раз. У Вас осталось {0} попыток", trys );
                }
            }
            Console.WriteLine("Cпасибо за использование программы!Нажмите любую клавишу что бы выйти");
            Console.ReadKey();
        }
    }
}
