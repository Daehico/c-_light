using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 38 * 17;
            int c = (31 – 5 * a) / b;
            Console.writeline(c);

            // В таком виде код не запустится, так как врайтлайн написан с ошибкой.(Надо WriteLine). Если не обращать внимание на это то в результате вычислений получится 0,03 (если я норм посчитал :D)
            //, но так как переменная инт - будет 0. Числа после точки оркгуляться, так как инт целочисленный тип переменной. 
        }
    }
}
