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
            #region Умножение матрицы на число
            //Умножение матрицы на число
            Console.Clear();
            Console.WriteLine("Умножение матрицы на число");
            Console.WriteLine("Введите размерность для матрицы");
            Console.WriteLine("Введите количество строк");
            var rowNumberMatrix = Convert.ToInt32(Console.ReadLine());     // ввод количества строк
            Console.WriteLine("Введите количество столбцов");
            var columnNumberMatrix = Convert.ToInt32(Console.ReadLine());  // ввод количества столбцов
            //Формируем и выводим на экран матрицу случайным образом
            Console.WriteLine("Дабы вас не перетруждать заполним случайным образом");
            Random randomNumber = new Random();
            int[,] matrix = new int[rowNumberMatrix, columnNumberMatrix];

            for (var i = 0; i < rowNumberMatrix; i++)
            {
                for (var j = 0; j < columnNumberMatrix; j++)
                {
                    matrix[i, j] = randomNumber.Next(100);
                    Console.Write(matrix[i, j] >= 100 ? ("  ") : matrix[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{matrix[i, j]}");
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine("Введите число на которое нужно умножить матрицу");
            var userNumber = Convert.ToInt32(Console.ReadLine());     // ввод числа

            int[,] newMatrix = new int[rowNumberMatrix, columnNumberMatrix];

            for (var i = 0; i < rowNumberMatrix; i++)
            {
                for (var j = 0; j < columnNumberMatrix; j++)
                {
                    newMatrix[i, j] = matrix[i, j] * userNumber;
                    Console.Write(newMatrix[i, j] >= 100 ? ("  ") : newMatrix[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{newMatrix[i, j]}");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу . . . ");
            Console.ReadKey();
            #endregion

            //Сложение и вычитание матриц
            #region Сложение и вычитание матриц
            Console.Clear();
            Console.WriteLine("Сложение матриц");
            Console.WriteLine("Введите размерность для матриц");
            Console.WriteLine("Складывать и вычетать можно только матрицы одинаковой размерности \nВведите размерность для матрицы 1 и 2");
            Console.WriteLine("Введите количество строк");
            var rowNumberMatrix1 = Convert.ToInt32(Console.ReadLine());     // ввод количества строк
            Console.WriteLine("Введите количество столбцов");
            var columnNumberMatrix1 = Convert.ToInt32(Console.ReadLine());  // ввод количества столбцов
            //Формируем и выводим на экран матрицу случайным образом
            Console.WriteLine("Дабы вас не перетруждать заполним случайным образом");
            int[,] matrix_1 = new int[rowNumberMatrix1, columnNumberMatrix1];
            int[,] matrix_2 = new int[rowNumberMatrix1, columnNumberMatrix1];
            int[,] matrix_1plus2 = new int[rowNumberMatrix1, columnNumberMatrix1];
            for (var i = 0; i < rowNumberMatrix1; i++)
            {
                for (var j = 0; j < columnNumberMatrix1; j++)
                {
                    matrix_1[i, j] = randomNumber.Next(100);
                    matrix_2[i, j] = randomNumber.Next(100);                    
                }                
            }
            Console.WriteLine("Матрица А:");
            for (var i = 0; i < rowNumberMatrix1; i++)
            {
                for (var j = 0; j < columnNumberMatrix1; j++)
                {
                    matrix_1[i, j] = randomNumber.Next(100);
                    Console.Write(matrix_1[i, j] >= 100 ? ("  ") : matrix_1[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{matrix_1[i, j]}");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Матрица В:");
            for (var i = 0; i < rowNumberMatrix1; i++)
            {
                for (var j = 0; j < columnNumberMatrix1; j++)
                {
                    matrix_2[i, j] = randomNumber.Next(100);
                    Console.Write(matrix_2[i, j] >= 100 ? ("  ") : matrix_2[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{matrix_2[i, j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Матрица С=А+В:");
            for (var i = 0; i < rowNumberMatrix1; i++)
            {
                for (var j = 0; j < columnNumberMatrix1; j++)
                {
                    matrix_1plus2[i, j] = matrix_1[i, j] + matrix_2[i, j];
                    Console.Write(matrix_1plus2[i, j] >= 100 ? ("  ") : matrix_1plus2[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{matrix_1plus2[i, j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Матрица С=А-В:");
            for (var i = 0; i < rowNumberMatrix1; i++)
            {
                for (var j = 0; j < columnNumberMatrix1; j++)
                {
                    matrix_1plus2[i, j] = matrix_1[i, j] - matrix_2[i, j];
                    Console.Write((matrix_1plus2[i, j] >= 100 || matrix_1plus2[i, j] < -9) ? ("  ") : (matrix_1plus2[i, j] >= 10 || matrix_1plus2[i, j] < 0) ? ("   ") : ("    "));
                    Console.Write($"{matrix_1plus2[i, j]}");                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу . . . ");
            Console.ReadKey();
            #endregion

            #region Умножение матриц
            //Умножение матриц
            Console.Clear();
            Console.WriteLine("Умножение матриц");
            Console.WriteLine("Введите размерность для матриц");
            Console.WriteLine("Складывать и вычетать можно только матрицы одинаковой размерности \nВведите размерность для матрицы 1 и 2");
            Console.WriteLine("Введите количество строк");







            Console.WriteLine("Для продолжения нажмите любую клавишу . . . ");
            Console.ReadKey();
            #endregion














        }
    }
}
