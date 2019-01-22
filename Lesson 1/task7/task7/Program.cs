using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество старушек в очереди:");
            uint queue = Convert.ToUInt32(Console.ReadLine());
            uint timeInQueue = 10;
            uint allTimeInOueue = timeInQueue * queue;
            Console.WriteLine("Вы простоите в очереди " + allTimeInOueue + " минут");
            Console.ReadKey();
        }
    }
}
