using System;


namespace HW4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctParse;
            #region Умножение матрицы на число
            //Умножение матрицы на число
            Console.Clear();
            Console.WriteLine("Умножение матрицы на число");
            Console.WriteLine("Введите размерность для матрицы");
            Console.WriteLine("Введите количество строк");
            int rowNumberMatrix, columnNumberMatrix;
            
            do 
            {
                correctParse = int.TryParse(Console.ReadLine(), out rowNumberMatrix); // ввод количества строк
                if (rowNumberMatrix <= 0) Console.WriteLine("Не коррекные данные, повторите ввод");
            }
            while (!correctParse || rowNumberMatrix<=0);
                        
            Console.WriteLine("Введите количество столбцов");

            do
            {
                correctParse = int.TryParse(Console.ReadLine(), out columnNumberMatrix); // ввод количества столбцов
                if (columnNumberMatrix <= 0) Console.WriteLine("Не коррекные данные, повторите ввод");
            }
            while (!correctParse ||columnNumberMatrix <= 0);
            
            //Формируем и выводим на экран матрицу случайным образом
            Console.WriteLine("Дабы вас не перетруждать заполним случайным образом");
            Random randomNumber = new Random();
            int[,] matrix = new int[rowNumberMatrix, columnNumberMatrix];

            for (var i = 0; i < rowNumberMatrix; i++)
            {
                for (var j = 0; j < columnNumberMatrix; j++)
                {
                    matrix[i, j] = randomNumber.Next(100);
                    //Console.Write(matrix[i, j] >= 100 ? ("  ") : matrix[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{matrix[i, j],5}");

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
                    //Console.Write(newMatrix[i, j] >= 100 ? ("  ") : newMatrix[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{newMatrix[i, j],7}");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу . . . ");
            Console.ReadKey();
            #endregion

            //Сложение и вычитание матриц
            #region Сложение и вычитание матриц
            int rowNumberMatrix1, columnNumberMatrix1;

            Console.Clear();
            Console.WriteLine("Сложение матриц");
            Console.WriteLine("Введите размерность для матриц");
            Console.WriteLine("Складывать и вычетать можно только матрицы одинаковой размерности \nВведите размерность для матрицы 1 и 2");
            Console.WriteLine("Введите количество строк");

            do
            {
                correctParse = int.TryParse(Console.ReadLine(), out rowNumberMatrix1); // ввод количества строк
                if (rowNumberMatrix1 <= 0) Console.WriteLine("Не коррекные данные, повторите ввод");
            }
            while (!correctParse || rowNumberMatrix1 <= 0);
            
            Console.WriteLine("Введите количество столбцов");

            do
            {
                correctParse = int.TryParse(Console.ReadLine(), out columnNumberMatrix1); // ввод количества столбцов
                if (columnNumberMatrix1 <= 0) Console.WriteLine("Не коррекные данные, повторите ввод");
            }
            while (!correctParse || columnNumberMatrix1 <= 0);
            
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
                    //Console.Write(matrix_1[i, j] >= 100 ? ("  ") : matrix_1[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{matrix_1[i, j],5}");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Матрица В:");
            for (var i = 0; i < rowNumberMatrix1; i++)
            {
                for (var j = 0; j < columnNumberMatrix1; j++)
                {
                    matrix_2[i, j] = randomNumber.Next(100);
                    //Console.Write(matrix_2[i, j] >= 100 ? ("  ") : matrix_2[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{matrix_2[i, j],5}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Матрица С=А+В:");
            for (var i = 0; i < rowNumberMatrix1; i++)
            {
                for (var j = 0; j < columnNumberMatrix1; j++)
                {
                    matrix_1plus2[i, j] = matrix_1[i, j] + matrix_2[i, j];
                    //Console.Write(matrix_1plus2[i, j] >= 100 ? ("  ") : matrix_1plus2[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{matrix_1plus2[i, j],5}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Матрица С=А-В:");
            for (var i = 0; i < rowNumberMatrix1; i++)
            {
                for (var j = 0; j < columnNumberMatrix1; j++)
                {
                    matrix_1plus2[i, j] = matrix_1[i, j] - matrix_2[i, j];
                    //Console.Write((matrix_1plus2[i, j] >= 100 || matrix_1plus2[i, j] < -9) ? ("  ") : (matrix_1plus2[i, j] >= 10 || matrix_1plus2[i, j] < 0) ? ("   ") : ("    "));
                    Console.Write($"{matrix_1plus2[i, j],5}");
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
            Console.WriteLine("Введите размерность для матрицы 1");
            Console.WriteLine("Введите количество строк");
            var rowNumberMatrixA = Convert.ToInt32(Console.ReadLine());     // ввод количества строк
            Console.WriteLine("Введите количество столбцов");
            var columnNumberMatrixA = Convert.ToInt32(Console.ReadLine());  // ввод количества столбцов
            Console.WriteLine("Определим размерность для матрицы 2");
            Console.WriteLine("Обязательное условие при умножении \nЧсло столбцов матрицы А равно количеству строк матрицы B\n\n");
            var rowNumberMatrixB = columnNumberMatrixA;
            Console.WriteLine($"Количество строк матрицы B= {rowNumberMatrixB}");
            Console.WriteLine("Введите количество столбцов матрицы B");
            var columnNumberMatrixB = Convert.ToInt32(Console.ReadLine());  // ввод количества столбцов
            
            Console.WriteLine("Дабы вас не перетруждать заполним случайным образом");
            int[,] matrix_A = new int[rowNumberMatrixA, columnNumberMatrixA];
            int[,] matrix_B = new int[rowNumberMatrixB, columnNumberMatrixB];
            int[,] matrix_C = new int[rowNumberMatrixA, columnNumberMatrixB];
            Console.WriteLine("Матрица А");
            for (var i = 0; i < rowNumberMatrixA; i++)
            {
                for (var j = 0; j < columnNumberMatrixA; j++)
                {
                    matrix_A[i, j] = randomNumber.Next(100);
                    Console.Write(matrix_A[i, j] >= 100 ? ("  ") : matrix_A[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{matrix_A[i, j]}");

                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nМатрица B");
            for (var i = 0; i < rowNumberMatrixB; i++)
            {
                for (var j = 0; j < columnNumberMatrixB; j++)
                {
                    matrix_B[i, j] = randomNumber.Next(100);
                    Console.Write(matrix_B[i, j] >= 100 ? ("  ") : matrix_B[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{matrix_B[i, j]}");

                }
                Console.WriteLine();
            }

            for (var i = 0; i < rowNumberMatrixA; i++)
            {
                for (var j = 0; j < columnNumberMatrixB; j++)
                {

                    for (var k = 0; k < columnNumberMatrixB; k++)
                    {
                        int temp_1, temp_2;
                        if (k < columnNumberMatrixA) temp_1 = matrix_A[i, k];
                        else temp_1 = 0;
                        if (k < rowNumberMatrixB) temp_2 = matrix_B[k, j];
                        else temp_2 = 0;
                        
                        matrix_C[i, j] += temp_1 * temp_2; ;

                        //строки для теста

                        //Console.WriteLine($"A[{i},{k}]={matrix_A[i, k]}    B[{k},{j}]={matrix_B[k, j]}   C[{i},{j}]={matrix_C[i, j]}");
                        //Console.ReadKey();
                    }
                    
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nМатрица C");
            for (var i = 0; i < rowNumberMatrixA; i++)
            {
                for (var j = 0; j < columnNumberMatrixB; j++)
                {
                    Console.Write(matrix_C[i, j] >= 100 ? ("  ") : matrix_C[i, j] >= 10 ? ("   ") : ("    "));
                    Console.Write($"{matrix_C[i, j]}");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Для продолжения нажмите любую клавишу . . . ");
            Console.ReadKey();
            #endregion














        }
    }
}
