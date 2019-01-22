using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество монет:");
            uint money = Convert.ToUInt32(Console.ReadLine());
            uint crystalcost = 5;
            uint howManyCanIBuy = money / crystalcost;
            Console.WriteLine("Вы можете купить " + howManyCanIBuy + " кристалов. Сколько кристалов вы хотите купить?");
            uint userCrystalWantToBuy = Convert.ToUInt32(Console.ReadLine());
            uint userMoneyBack = money % userCrystalWantToBuy;
            Console.WriteLine("Вы купили:" + userCrystalWantToBuy + " кристалов. У вас осталось " + userMoneyBack + " золота");
            Console.ReadKey();
            // Здесь бы еще было хорошо сделать проверку, на то что число вводимое пользователем не больше того которого он может купить. Но без условных операторов хз как это сделать
        }
    }
}
