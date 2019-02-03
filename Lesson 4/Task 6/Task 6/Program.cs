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
            string[] array = new string[1];
            string[] arrayCopy;
            string text;
            int id;
            while (true)
            {
                Console.Write("Введите команду: ");
                string comand = Console.ReadLine();
                if (comand.ToLower() == "добавить")
                {
                    Console.Write("Введите текст, который хотите добавить в масив: ");
                    text = Console.ReadLine();
                    array = Add(array, text);
                   
                }
                else if (comand.ToLower() == "удалить")
                {
                    Console.Write("Введите индекс массива который вы хотите удалить:");
                    id = Convert.ToInt32(Console.ReadLine());
                    if (id <= array.Length - 1)
                        array = Delete(array, id);
                    else
                        Console.WriteLine("Вы ввели не корректное число");
                }               

                else if (comand.ToLower() == "копировать")
                {
                    arrayCopy = ArrayCopy(array);
                   
                }
                else
                {
                    Console.WriteLine("Такой команды не существует");
                }

            }
        }

        static string[] Delete (string[] array, int id)
        {
            array[id] = null; // при выводе массива в цикле прописать что эллементы массива имеющие значение null не выводятся
            return array;
            
        }
        static string[] Add (string[] array, string text )
        {
            string[] arrayCopy = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayCopy[i] = array[i];
            }
            array = new string[arrayCopy.Length + 1];
            for (int i = 0; i < arrayCopy.Length; i++)
            {
                array[i] = arrayCopy[i];
            }
            array[array.Length - 1] = text;
            return array;

        }
        static string[] ArrayCopy (string[] array)
        {
            string[] arrayCopy = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayCopy[i] = array[i];
            }
            return arrayCopy;
        }
        

    }
}
