using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static int health = 4;

        static void Main(string[] args)
        {
            while (true)
            {
                drawBar(health, 10, 0);
                
                Console.SetCursorPosition(0, 2);
                health += Convert.ToInt32(Console.ReadLine());
                
                System.Threading.Thread.Sleep(1000);
            }
        }

        static void drawBar(int value, int maxBar, int position)
        {            
            Console.SetCursorPosition(0, position);
            //Console.BackgroundColor = defaultColor;
            Console.Write('[');
           
            string bar = "";
            Console.Write(bar.PadRight(value, '#'));
            bar = "";
            
            Console.SetCursorPosition(value + 1, position);
            Console.Write(bar.PadRight(maxBar - value, '_') + ']');
        }
    }
}
