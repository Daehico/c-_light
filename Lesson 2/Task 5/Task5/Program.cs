using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Добро пожаловать! Данная программа обведет ваше имя в красивую рамочку из выбранного вами символа. Введите ваше имя:");
            string userName = Console.ReadLine();
            Console.Write("Введите символ, которым вы хотите отрисовать табличку. Для корретной работы введите только один символ: ");
            string _char = Console.ReadLine();
            if (_char.Length >1)
            {
                Console.WriteLine("Введенное cимвол не корректен!");
            }
            else
            {
                int height = 4;
                int width = userName.Length + 2;
                for (int i = 0; i < width; i++)
                {
                    Console.SetCursorPosition(i, 2);
                    Console.Write(_char);
                    Console.SetCursorPosition(i, height);
                    Console.Write(_char);
                }
                for (int i = 2; i < height; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write(_char);
                    if (i == 3)
                    {
                        Console.SetCursorPosition(1, i);
                        Console.Write(userName);
                    }

                    Console.SetCursorPosition(width - 1, i);
                    Console.Write(_char);
                }

            }

            Console.SetCursorPosition(0, 5);
            Console.WriteLine("Спасибо за использование программы. Нажмите любую клавишу что бы выйти");
            Console.ReadKey();
        }
    }
}
