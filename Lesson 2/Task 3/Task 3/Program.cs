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
            Console.Write("Добро пожаловать! Введите вашу команду: ");
           string command =  Console.ReadLine();
            string name = "";
            string password = "";
            string color = "";
            string foreGroundColor = "";
            while (command != "Выход")
            {
                if (command == "Установить имя")
                {
                    Console.Write("Введите ваше имя");
                    name = Console.ReadLine();
                    Console.WriteLine("Приветсвую, {0}!  ", name);
                    
                }
                else if (command == "Установить пароль")
                {
                    Console.Write("Введите имя для которого вы хотите установить пароль");
                    string checkName = Console.ReadLine();
                    if (checkName == name)
                    {
                        Console.Write("Введите пароль");
                        password = Console.ReadLine();
                        Console.WriteLine("Пароль для имени {0} установлен.  ", name);
                    }
                    else
                    {
                        Console.WriteLine("Имя не найденно. Для начало создайте имя либо проверьте правильность ввода. Введите вашу команду: ");
                    }
                }
                else if (command == "Вывести имя")
                {
                    if (name == "")
                    {
                        Console.WriteLine("Имя не найдено!");

                    }
                    else
                    {
                        Console.WriteLine("Ваше имя {0}.", name);
                    }
                    
                }
                else if (command == "Поменять цвет консоли")
                {
                    Console.Write("Вы хотите поменять цвет консоли?На выбор доступный три цвета: черный, серый, красный");
                    color = Console.ReadLine();
                    if (color == "черный")
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine("Цвет консоли стал {0}. ", color);
                    }
                    else if (color == "серый")
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Цвет консоли стал {0}. ", color);
                    }
                    else if (color == "красный")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Цвет консоли стал {0}. ", color);
                    }
                    else
                    {
                        Console.WriteLine("Цвет не найден. ");
                    }
                }
                else if (command == "Поменять цвет шрифта") {
                    Console.Write("Вы хотите поменять цвет шрифта? На выбор доступный три цвета: черный, серый, красный");
                    foreGroundColor = Console.ReadLine();
                    if (foreGroundColor == "черный")
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Цвет шрифта стал {0}.  ", foreGroundColor);
                    }
                    else if (foreGroundColor == "серый")
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Цвет шрифта стал {0}.  ", foreGroundColor);
                    }
                    else if (foreGroundColor == "красный")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Цвет шрифта стал {0}.  ", foreGroundColor);
                    }
                    else
                    {
                        Console.WriteLine("Цвет не найден.");
                    }
                }

                else if (command == "Список команд")
                {
                    Console.WriteLine("Cписок доступных команд: Установить имя, Установить пароль, Вывести имя, Поменять цвет консоли, Поменять цвет шрифта . " +
                        "/r/n Для выхода из программы используйте команду Выъод.  Для корректной работы команды необходимо вводить точно также как они указаны в списке с учетом регистра!");
                }
                else
                {
                    Console.WriteLine("Команда не найдена. Воспользуйтесь командой Список команд ( с учетом регистра), что бы увидеть список доступных команд");
                }

                Console.WriteLine("Введите команду: ");
                 command = Console.ReadLine();
            }

            Console.WriteLine("Спасибо за использование программы! Нажмите любую клавишу, что бы выйти");
            Console.ReadKey();
        }
    }
}
