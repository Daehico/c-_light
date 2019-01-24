using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Привет! Как тебя зовут?");
            string userName = Console.ReadLine();
            Console.Write("Привет {0}! Сколько тебе лет?", userName);
            int userYersOld = Convert.ToInt32(Console.ReadLine());
            if (userYersOld < 18)
            {
                Console.WriteLine("Извини, но тебе закрыт доступ к программе");
            }
            else
            {
                Console.Write("Замечательно. Ты ходишь в школу?");
                string userGoToSchool = Console.ReadLine();
                if (userGoToSchool == "да")
                {
                    Console.WriteLine("Обманщик,тебе нет 18!");
                }
                else
                {
                    Console.Write("Cентябрь гориииит... /r/n 1) Убийца плачет /r/n/ 2) Птица парит /r/n 3) Что это вообще такое?");
                    string stigmata = Console.ReadLine();
                    if (stigmata == "1" && stigmata == "2")
                    {
                        Console.WriteLine("Обманщик!");

                    }
                    else if (stigmata == "3")
                    {
                        Console.WriteLine("Блеск! Ты прошел мой тест");
                    }

                }
            }
        }
    }
}
