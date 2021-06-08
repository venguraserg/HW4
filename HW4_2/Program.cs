using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int c = 1;

            Console.Write("Введите количество строк: ");
            var nunberRow = int.Parse(Console.ReadLine());
            for (var i = 0; i < nunberRow; i++)
            {
                for (var emptyCell = 1; emptyCell <= nunberRow - i; emptyCell++)
                   Console.Write($"{"",-3}");


                for (var j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        c = 1;
                    else
                        c = c * (i - j + 1) / j;
                    Console.Write($"{c,-6}");
                    //Console.Write(c >= 100 ? (" ") : c >= 10 ? ("  ") : ("   "));

                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
