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
            while (true)
            {
                Console.Write("Введите команду: ");
                string[] array = new string[1];
                string[] arrayCopy;
                string text;
                int id;
                string comand = Console.ReadLine();
                if (comand.ToLower() == "удалить")
                {
                    Console.Write("Введите индекс массива который вы хотите удалить:");
                    id = Convert.ToInt32(Console.ReadLine());
                    if (id <= array.Length - 1)
                        Delete(array, id);
                    else
                        Console.WriteLine("Вы ввели не корректное число");
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] == null)
                            continue;
                        Console.WriteLine(array[i]);
                    }
                }
               else  if (comand.ToLower() == "добавить")
                {
                    Console.Write("Введите текст, который хотите добавить в масив: ");
                    text = Console.ReadLine();
                    array = Add(array, text);
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
                else if (comand.ToLower() == "копировать") 
                {
                   arrayCopy =  ArrayCopy(array);
                    for (int i = 0; i < arrayCopy.Length; i++)
                    {
                        Console.WriteLine(arrayCopy[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Такой команды не существует");
                }

            }
        }

        static string[] Delete (string[] array, int id)
        {
            array[id] = null;
            return array;
            
        }
        static string[] Add (string[] array, string text )
        {

            string[] arrayCopy = ArrayCopy(array);
            array = new string[arrayCopy.Length + 1];
            array = ArrayCopy(arrayCopy);
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
