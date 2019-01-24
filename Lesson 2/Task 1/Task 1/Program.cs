using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Добро пожаловать!\r\n Перед вами находится не открытая дверь. Открыть ее может только лицо достигшее 18 лет.  Сколько Вам лет?");
            uint userYersOld = Convert.ToUInt32(Console.ReadLine());
            bool isDoorOpen = false;
            if (userYersOld >= 18)
            {
                isDoorOpen = true;
                Console.WriteLine("Дверь открыта");
            }
            else
            {
                isDoorOpen = false;
                Console.WriteLine("Дверь закрыта. Вам нет 18");
            }
            Console.ReadKey();
        }
    }
}
