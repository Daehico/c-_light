using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int _img = 52;
            int _imgInRows = 3;

            int _rowsResult = _img / _imgInRows;
            int _remainderResult = _img % _imgInRows;

            Console.WriteLine("Полностью заполненных рядов: " + _rowsResult + ". Картинок сверх меры: "  + _remainderResult);
            Console.ReadKey();
        }
    }
}
