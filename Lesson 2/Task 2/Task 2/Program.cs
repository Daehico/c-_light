using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Добро пожаловать в ковертер валют! Для обмена доступны 3 валюты. Доллары, евро и биткоин. " +
                "(Вводить в точности как написано в предложении перед скобками. Можно без учета регистра). Введите название валюты:");
            string name = Console.ReadLine();
            if (name.ToLower() == "доллары" || name.ToLower() == "биткоин" || name.ToLower() == "евро")
            {
                Console.Write("Введите сумму, которую хотите обменять: ");
                float money = Convert.ToSingle(Console.ReadLine());
                if (money < 0)
                {
                    Console.WriteLine("Вы ввели не корректную сумму");
                }
                else
                {
                    Console.Write("Введите валюту в которую хотите конвертировать: ");
                    string nameConvertation = Console.ReadLine();
                    if (nameConvertation.ToLower() == "доллары" || nameConvertation.ToLower() == "биткоин" || nameConvertation.ToLower() == "евро")
                    {
                        float conversionRate;
                        float result;
                        if (name.ToLower() == "доллары" && nameConvertation.ToLower() == "евро")
                        {
                            conversionRate = 1.5f;
                            result = money * conversionRate;
                            Console.WriteLine("Вы обменяли: " +money.ToString("0.00") + "долларов. Теперь у вас " + result.ToString("0.00") + "евро.");
                        }
                        else if (name.ToLower() == "доллары" && nameConvertation.ToLower() == "биткоин")
                        {
                            conversionRate = 0.3f;
                            result = money * conversionRate;

                            Console.WriteLine("Вы обменяли: " + money.ToString("0.00") + "долларов. Теперь у вас " + result.ToString("0.00") + "биткоинов.");
                        }
                        else if (name.ToLower() == "евро" && nameConvertation.ToLower() == "биткоин")
                        {
                            conversionRate = 0.2f;
                            result = money * conversionRate;
                            Console.WriteLine("Вы обменяли: " + money.ToString("0.00") + "евро. Теперь у вас " + result.ToString("0.00") + "биткоинов.");
                        }

                        else if (name.ToLower() == "евро" && nameConvertation.ToLower() == "доллары")
                        {
                            conversionRate = 2.7f;
                            result = money * conversionRate;
                            Console.WriteLine("Вы обменяли: " + money.ToString("0.00") + "евро. Теперь у вас " + result.ToString("0.00") + "долларов");
                        }
                        else if (name.ToLower() == "биткоин" && nameConvertation.ToLower() == "доллары")
                        {
                            conversionRate = 3600f;
                            result = money * conversionRate;
                            Console.WriteLine("Вы обменяли: " + money.ToString("0.00") + "биткоинов. Теперь у вас " + result.ToString("0.00") + "долларов.");
                        }
                        else if (name.ToLower() == "биткоин" && nameConvertation.ToLower() == "евро")
                        {
                            conversionRate = 3800f;
                            result = money * conversionRate;
                            Console.WriteLine("Вы обменяли: " + money.ToString("0.00") + "биткоинов. Теперь у вас " + result.ToString("0.00") + "евро.");
                        }
                    }
                }
                }
            
            else
            {
                Console.WriteLine("Введенное наименование валюты не корректно");
            }

            Console.ReadKey();
          
        }
    }
}
