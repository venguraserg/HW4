using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HW4_1
{
    class Program
    {
        //Для месяцев попробуем использовать перечислением (для практики)
        enum Months
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }

        static void Main(string[] args)
        {
            int[,] massive = new int[12, 4];            //инициализируем массив для хранения данных
            Random r = new Random();                    //инициализируем генератор случайных чисел   

            for (var i = 0; i < 12; i++)                // Генерируем таблицу
            {
                for (var j = 0; j < 4; j++)
                {
                    switch (j)
                    {
                        case 0:
                            // Месяца по порядку                            
                            massive[i, j] = i+1;
                            break;
                        case 1:
                            //Рандомное заполнение дохода
                            massive[i, j] = /*2;*/r.Next(30);
                            break;
                        case 2:
                            //Рандомное заполнение расхода
                            massive[i, j] = /*2;*/r.Next(40);
                            break;
                        case 3:
                            //Расчет прибыли
                            massive[i, j] = massive[i, j - 2] - massive[i, j - 1];      //рачситаем прибыль = доход - расход
                            break;
                    }
                }              
            }
            //Так как заказчик крупная компания, то и вывод таблицы должен быть красивым)))

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("| Месяц     |     Доход     |     Расход    |     Прибыль   |");
            Console.WriteLine("-------------------------------------------------------------");
            for (var i = 0; i < 12; i++)
            {
                
                Console.Write($"| {(Months)massive[i, 0],-10}");                                                            //Выводим месяц через ENUM
                
                Console.Write($"|     {massive[i, 1],-10}");                                //выводим доход и распаолаем ровно в таблице
                
                Console.Write($"|     {massive[i, 2],-10}");                                //Далее анологично для остальных столбцов
                
                Console.Write($"|     {massive[i, 3],-10}"+"|\n");
                
            }
            Console.WriteLine("-------------------------------------------------------------");

            // Определение колдичества месяцев с положительной прибылью
            int countMonth = 0;
            for (int i=0; i<12; i++)
            {
                if (massive[i, 3] > 0) countMonth++;
            }
            Console.WriteLine("\nКоличество месяцев с положительной прибылью составляет " + countMonth);

            //определение трех месяцев наименьшей прибылью, при этом месяцы с одинаковой прибылью считаются за один.
            int[] tempArray = new int[12];
            for(var i = 0; i < 12; i++)
            {
                tempArray[i] = massive[i, 3];
            }
            
            Array.Sort(tempArray);

            int[] worstProfits = new int[3];
            bool matrixSameVal = false;
            for (int i = 1, count = 0; i < 12; i++)
            {
                if (count >= worstProfits.Length) break;
                if (tempArray[i] != tempArray[i - 1])
                {
                    worstProfits[count] = tempArray[i-1];
                    count++;
                    matrixSameVal = false;
                }
                else
                {
                    matrixSameVal = true;
                }
            }

            Console.WriteLine($"\nТри худщие прибыли это: {worstProfits[0]}\t{worstProfits[1]}\t{worstProfits[2]}\t\n");

            int[,] reportMassive = new int[12,2];

            

            for (int i = 0, count =0; i < 12; i++)
            {
                for (int j = 0; j < (matrixSameVal ? 1 : 3); j++)
                {
                    if (massive[i, 3] == worstProfits[j])
                    {
                        reportMassive[count, 0] = massive[i, 0];
                        reportMassive[count,1] = massive[i, 3];
                        count++;
                    }
                    
                }
            }
            Console.WriteLine("Наименьшая прибыль (Наибольший убыток) по месяцам\n");
            
            for (var i = 0; i < 12; i++)
            {
                if(reportMassive[i,0]!=0)Console.WriteLine($" {(Months)reportMassive[i, 0],-10}{reportMassive[i, 1],5}");
            }
           

            Console.WriteLine("\n\nДля продолжения нажмите любую клавишу . . . ");
            Console.ReadKey();
        }
    }
}
