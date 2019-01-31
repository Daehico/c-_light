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
            string[] fioArray = new string[1];
            string[] positionArray = new string[1];
            Console.Write("Введите команду: ");
            string comand = Console.ReadLine();
            
            while (comand.ToLower() != "выход")
            {
                if (comand.ToLower() == "добавить досье")
                {
                    Adddossier(fioArray, positionArray);
                    
                }
                if (comand.ToLower() == "вывести все досье")
                {
                    SeeAllDossier(fioArray, positionArray);
                }
                if (comand.ToLower() == "удалить досье")
                {
                    DeleteDossier(fioArray, positionArray);
                }
                Console.Write("Введите команду: ");
                comand = Console.ReadLine();
            }

            
        }

        static void Adddossier(string[] fioArray,string[] positionArray)
        {
            string name;
            string position;
            
            string[] fioArrayCopy;
            string[] positionArrayCopy;

            Console.Write("Введите имя: ");
            name = Console.ReadLine();   
            Console.Write("Введите должность: ");
            position = Console.ReadLine();
            
            Array.Copy(fioArray,  fioArrayCopy = new string[fioArray.Length], fioArray.Length);
            Array.Copy(positionArray, positionArrayCopy = new string[positionArray.Length], positionArray.Length);
            Array.Resize<string>(ref fioArray, fioArray.Length + 1);
            Array.Resize<string>(ref positionArray, positionArray.Length + 1);
            for (int i = 0; i < fioArrayCopy.Length; i++)
            {
                fioArray[i] = fioArrayCopy[i];
                positionArray[i] = positionArrayCopy[i];
            }
            fioArray[fioArray.Length - 1] = name;
            positionArray[positionArray.Length-1] = position;
        }

        static void SeeAllDossier(string[] fioArray, string[] positionArray)
        {
           for (int i = 0; i < fioArray.Length; i++)
            {
            Console.WriteLine(i + ")" + fioArray[i], positionArray[i]);
            }
        }

        private static void DeleteDossier(string[] fioArray, string[] positionArray)
        {
            Console.Write("Введите ID сотрудника досье которого вы хотите удалить. Для того что бы узнать ID сотруддника ввыведите список сотрудников через команду вывести все досье: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Array.Clear(fioArray, id,id);
            Array.Clear(positionArray, id, id);
        }

    }
    
}
