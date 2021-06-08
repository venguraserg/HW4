using System;

namespace HW4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Для вывода применеа интерполяция строк
            int c = 1;
            Console.SetWindowSize(200,40);
            Console.Write("Введите количество строк: ");
            var nunberRow = int.Parse(Console.ReadLine());
            for (var i = 0; i < nunberRow; i++)
            {
                for (var emptyCell = 1; emptyCell <= nunberRow - i; emptyCell++)
                   Console.Write($"{"",4}"); // интерполяция здесь


                for (var j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        c = 1;
                    else
                        c = c * (i - j + 1) / j;
                    Console.Write($"{c,-8}"); // интерполяция здесь
                    //Console.Write(c >= 100 ? (" ") : c >= 10 ? ("  ") : ("   ")); // старый вариант хорош для 10 строк)))

                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
