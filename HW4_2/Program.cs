using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW4_2
{
    class Program
    {
        // Чать кода взята на стекОверфлоу для максимизации консоли
        // Что тут происходит до конца не знаю)))
        // но работает
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int MAXIMIZE = 3;
        


        static void Main(string[] args)
        {
            //Увеличивает экран для красивого вывода
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);

            int c = 1;

            Console.Write("Введите количество строк: ");
            var nunberRow = int.Parse(Console.ReadLine());
            for (var i = 0; i < nunberRow; i++)
            {
                for (var emptyCell = 1; emptyCell <= nunberRow - i; emptyCell++)
                    Console.Write($"{"",4}");  // для красивого вывода примеим интерполяцию строк


                for (var j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        c = 1;
                    else
                        c = c * (i - j + 1) / j;
                    Console.Write($"{c,8}");// для красивого вывода примеим интерполяцию строк
                    //Console.Write(c >= 100 ? (" ") : c >= 10 ? ("  ") : ("   ")); 

                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
