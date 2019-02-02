using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
     
            static void Main(string[] args)
            {
                int a = 10, b = 15, c = 0;
                SomeMul(a, b, c);
                char[] map = new char[15];
                map[2] = 'T';
                GenerateMap(map);
                Console.WriteLine(c); // 0 так как инт не ссылочный тип (то есть ини значимый тип), а модификатор реф мы не используем. Мы работаем с самим значением переменной а не с ее ссылкой
                Console.WriteLine(map[2]); // P так как чар это ссылочный тип 
            
            }
            static void SomeMul(int a, int b, int c)
            {
                c = a * b;
            }
            static void GenerateMap(char[] map)
            {
                for (int i = 0; i < map.Length; i++)
                {
                    map[i] = 'P';
                }
            }
        }
    }

