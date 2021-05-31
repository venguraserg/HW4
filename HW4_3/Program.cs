using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы");
            Console.WriteLine("Введите количество строк");
            var rowNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            var columnNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Дабы вас не перетруждать заполним случайным образом");
            Random randomNumber = new Random();

            int[,] matrix_1 = new int[rowNumber, columnNumber];
            int[,] matrix_2 = new int[rowNumber, columnNumber];
            int[,] matrix_3 = new int[rowNumber, columnNumber];
            Console.WriteLine("Матрица 1:");
            for (var i=0; i<rowNumber; i++)
            {
                for(var j=0; j<columnNumber; j++)
                {
                    matrix_1[i, j] = randomNumber.Next(100);
                    Console.Write(matrix_1[i, j] >= 100 ? ("  ") : matrix_1[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{matrix_1[i,j]}"); 
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Матрица 2:");
            for (var i = 0; i < rowNumber; i++)
            {
                for (var j = 0; j < columnNumber; j++)
                {
                    matrix_2[i, j] = randomNumber.Next(100);
                    Console.Write(matrix_2[i, j] >= 100 ? ("  ") : matrix_2[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{matrix_2[i, j]}");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nДля продолженния нажмите любую клавишу...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Умножение матрицы на число:");
            Console.WriteLine("Введите число на которое умножим");
            var userNumber = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < rowNumber; i++)
            {
                for (var j = 0; j < columnNumber; j++)
                {
                    matrix_3[i, j] = matrix_1[i, j] * userNumber;
                    Console.Write(matrix_3[i, j] >= 100 ? ("  ") : matrix_3[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{matrix_3[i, j]}");
                   
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nДля продолженния нажмите любую клавишу...");
            Console.ReadKey();


        }
    }
}
