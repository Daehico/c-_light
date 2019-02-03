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
                    
                   fioArray = AdddossierName(fioArray);
                   positionArray = AddDossierPosition(positionArray);  
                }
                if (comand.ToLower() == "вывести все досье")
                {
                    SeeAllDossier(fioArray, positionArray);
                }
                if (comand.ToLower() == "удалить досье")
                {
                    Console.Write("Введите ID сотрудника досье которого вы хотите удалить. Для того что бы узнать ID сотруддника ввыведите список сотрудников через команду вывести все досье: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    fioArray = DeleteDossierName(fioArray,id);
                    positionArray = DeleteDossierPosition(fioArray, id);
                }
                Console.Write("Введите команду: ");
                comand = Console.ReadLine();
            }

            
        }

        static string[] AdddossierName(string[] fioArray)
        {
            string name;
            
            
            string[] fioArrayCopy;
            

            Console.Write("Введите имя: ");
            name = Console.ReadLine();   
           
            
            Array.Copy(fioArray,  fioArrayCopy = new string[fioArray.Length], fioArray.Length);
            
            Array.Resize(ref fioArray, fioArray.Length + 1);
           
            for (int i = 0; i < fioArrayCopy.Length; i++)
            {
                fioArray[i] = fioArrayCopy[i];
                
            }
            fioArray[fioArray.Length - 1] = name;
           
            return fioArray;
        }
        static string[] AddDossierPosition(string[] positionArray)
        {
            string position;
            string[] positionArrayCopy;
            Console.Write("Введите должность: ");
            position = Console.ReadLine();
            Array.Copy(positionArray, positionArrayCopy = new string[positionArray.Length], positionArray.Length);
            Array.Resize(ref positionArray, positionArray.Length + 1);
            for (int i = 0; i < positionArrayCopy.Length; i++)
            {
                positionArray[i] = positionArrayCopy[i];
            }
            positionArray[positionArray.Length - 1] = position;
            return positionArray;
        }

        static void SeeAllDossier(string[] fioArray, string[] positionArray)
        {
           for (int i = 0; i < fioArray.Length; i++)
            {
                if (fioArray[i] == null || positionArray[i] == null)
                    continue;
                else
            Console.WriteLine("{0}) ФИО - {1}; Должность - {2} ",i,fioArray[i],positionArray[i]);
            }
        }

       static string[] DeleteDossierName(string[] fioArray, int id)
        {
           
            Array.Clear(fioArray, id,id);
            return fioArray;
           
        }
        static string[] DeleteDossierPosition(string[] positionArray,int id)
        {
            Array.Clear(positionArray, id, id);
            return positionArray;
        }

    }
    
}
