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
                "(Вводить с маленькой буквы и в точности как написано в предложении перед скобками). Введите название валюты:");
           string name = Console.ReadLine();
            //if (name != "доллары" || name != "евро" || name != "биткоин")
            //{
            //    Console.WriteLine("Вы ввели не корректное название валюты.");
            //}
            //else
            //{
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
                    //if (nameConvertation != "доллары" || nameConvertation != "евро" || nameConvertation != "биткоин")
                    //{
                    //    Console.WriteLine("Вы ввели не корректное название валюты.");
                    //}
                    //else
                    //{
                        float conversionRate;
                        float result;
                        if (name == "доллары" && nameConvertation == "евро")
                        {
                            conversionRate = 1.5f;
                            result = money * conversionRate;
                            Console.WriteLine("Вы обменяли {0} {1}. Теперь у вас {2] {3}", money, name, result.ToString("0.00"), nameConvertation);
                        }
                        else if (name == "доллары" && nameConvertation == "биткоин")
                        {
                            conversionRate = 0.3f;
                            result = money * conversionRate;
                            Console.WriteLine("Вы обменяли {0} {1}. Теперь у вас {2] {3}", money, name, result.ToString("0.00"), nameConvertation);
                        }
                        else if (name == "евро" && nameConvertation == "биткоин")
                        {
                            conversionRate = 0.2f;
                            result = money * conversionRate;
                            Console.WriteLine("Вы обменяли {0} {1}. Теперь у вас {2] {3}", money, name, result.ToString("0.00"), nameConvertation);
                        }

                        else if (name == "евро" && nameConvertation == "доллар")
                        {
                            conversionRate = 2.7f;
                            result = money * conversionRate;
                            Console.WriteLine("Вы обменяли {0} {1}. Теперь у вас {2] {3}", money, name, result.ToString("0.00"), nameConvertation);
                        }
                        else if (name == "биткоин" && nameConvertation == "доллар")
                        {
                            conversionRate = 3600f;
                            result = money * conversionRate;
                    string stringResult = result.ToString("0.00");
                            Console.WriteLine("Вы обменяли {0} {1}. Теперь у вас {2] {3}", money, name, stringResult, nameConvertation);
                        }
                        else if (name == "биткоин" && nameConvertation == "евро")
                        {
                            conversionRate = 3800f;
                            result = money * conversionRate;
                            Console.WriteLine("Вы обменяли {0} {1}. Теперь у вас {2] {3}", money, name, result.ToString("0.00"), nameConvertation);
                        }
                    }
            Console.ReadKey();
        }
            
        }
           

            //if (money < 0)
            //{
            //    Console.WriteLine("Вы ввели не корректную сумма");
            //}
            //else if (name != "доллары" || name != "евро" || name != "биткоин" || name != "биткоины" || name != "доллар" /*|| nameConvertation != "доллары" || nameConvertation != "евро" || nameConvertation != "биткоин" || nameConvertation != "биткоины" || nameConvertation != "доллар"*/)
            //{
            //    Console.WriteLine("Вы ввели не корректное название валюты.");
            //} 
            //else if (name == "доллары" || name == "доллар" && nameConvertation =="евро")
            //{
            //    conversionRate = 1.5f;
            //    result = money * conversionRate;
            //    Console.WriteLine("Вы обменяли {0} {1}. Теперь у вас {2] {3}", money, name, result.ToString("0.00"), nameConvertation);
            //}
            //else if ((name == "доллары" || name == "доллар") && (nameConvertation == "биткоин" || nameConvertation == "биткоины"))
            //{
            //    conversionRate = 0.3f;
            //    result = money * conversionRate;
            //    Console.WriteLine("Вы обменяли {0} {1}. Теперь у вас {2] {3}", money, name, result.ToString("0.00"), nameConvertation);
            //}
            //else if (name == "евро" && nameConvertation == "биткоин" || nameConvertation == "биткоины")
            //{
            //    conversionRate = 0.2f;
            //    result = money * conversionRate;
            //    Console.WriteLine("Вы обменяли {0} {1}. Теперь у вас {2] {3}", money, name, result.ToString("0.00"), nameConvertation);
            //}

            //else if (name == "евро" && nameConvertation == "доллар" || nameConvertation == "доллары")
            //{
            //    conversionRate = 2.7f;
            //    result = money * conversionRate;
            //    Console.WriteLine("Вы обменяли {0} {1}. Теперь у вас {2] {3}", money, name, result.ToString("0.00"), nameConvertation);
            //}
            //else if (name == "биткоин" || name == "биткоины" && nameConvertation == "доллар" || nameConvertation == "доллары")
            //{
            //    conversionRate = 3600f;
            //    result = money * conversionRate;
            //    Console.WriteLine("Вы обменяли {0} {1}. Теперь у вас {2] {3}", money, name, result.ToString("0.00"), nameConvertation);
            //}
            //else if (name == "биткоин" || name == "биткоины" && nameConvertation == "евро")
            //{
            //    conversionRate = 3800f;
            //    result = money * conversionRate;
            //    Console.WriteLine("Вы обменяли {0} {1}. Теперь у вас {2] {3}", money, name, result.ToString("0.00"), nameConvertation);
            //}

            //Console.ReadKey();
        }
    //}
//}
