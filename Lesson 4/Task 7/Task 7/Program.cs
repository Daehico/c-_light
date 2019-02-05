using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "здесь","какие-то","слова","О_о" };
            array = Shuffle(array);
            Console.ReadKey();
        }

        static string[] Shuffle(string[] array)
        {
            Random rand = new Random();
            int[] randomArray = new int[1];
            int[] copy;
            for (int i = 0; i < array.Length; i++)
            {
                int random = rand.Next(0, array.Length);
                array[i] = array[random];
               
                Array.Copy(randomArray, copy = new int[randomArray.Length+1], randomArray.Length);

                Array.Resize(ref randomArray, randomArray.Length + 1);

                for (int j = 0; j < randomArray.Length; j++)
                {
                    
                        randomArray[j] = copy[j];

                }

            }
            return array;
        } 
        
    }
}
