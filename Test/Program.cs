using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            var number = int.MaxValue;//Convert.ToInt32(Console.ReadLine());
            int i=0;
            if (number < 0) number = -number;
            while (number > 0)
            {
              number = number / 10;
              i++;
            }
            Console.WriteLine(i);
            
            Console.WriteLine("Для продолжения нажмите любую клавишу . . . ");
            Console.ReadKey();
        }
    }
}
