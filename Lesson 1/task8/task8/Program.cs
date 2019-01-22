using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество старушек в очереди:");
            uint queue = Convert.ToUInt32(Console.ReadLine());
            uint timeInQueue = 10;
            uint allTimeInOueue = timeInQueue * queue;
            uint hours = allTimeInOueue / 60;
            uint minuts = allTimeInOueue % 60;

            Console.WriteLine("Вы простоите в очереди " + hours + " часов " + minuts + " минут");
            Console.ReadKey();
        }
    }
}
