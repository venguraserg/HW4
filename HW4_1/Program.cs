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
                            massive[i, j] = r.Next(3);
                            break;
                        case 2:
                            //Рандомное заполнение расхода
                            massive[i, j] = r.Next(3);
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
                //for (var k = 0; k < (10 - (((Months)massive[i, 0]).ToString()).Length); k++) { Console.Write(" "); }    //Считаем отступы, чтобы таблица была ровной
                
                Console.Write($"|     {massive[i, 1],-10}");                                //выводим доход и распаолаем ровно в таблице
                //var number = massive[i, 1];                                          // получаем колличество символов числа
                //int count = 0;
                //if (number < 0) number = -number;
                //while (number > 0)
                //{
                //    number = number / 10;
                //    count++;
                //}
                //for (var k = 0; k < (10 - count); k++) { Console.Write(" "); }          //Расчитываем отступ

                Console.Write($"|     {massive[i, 2],-10}");                                //Далее анологично для остальных столбцов
                //number = massive[i, 2];
                //count = 0;
                //if (number < 0) number = -number;
                //while (number > 0)
                //{
                //    number = number / 10;
                //    count++;
                //}
                //for (var k = 0; k < (11 - count); k++) { Console.Write(" "); }

                Console.Write($"|     {massive[i, 3],-10}"+"|\n");
                //number = massive[i, 3];
                //count = 0;
                //if (number < 0) 
                //{
                //    number = -number;
                //    count++;
                //}
                //while (number > 0)
                //{
                //    number = number / 10;
                //    count++;
                //}
                //for (var k = 0; k < (13 - count); k++) { Console.Write(" "); }
                //Console.WriteLine("*");
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

            for (int i = 0, count = 0; i < 12; i++)
            {
                if (tempArray[i] != tempArray[i + 1])
                {
                    worstProfits[count] = tempArray[i];
                    count++;

                }
                if (count > 2) break;
            }


            int[,] reportMassive = new int[12, 2];

            for (int i = 0, count =0; i < 3; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (worstProfits[i] == massive[j, 3])
                    {
                        reportMassive[count, 0] = massive[j, 3];
                        count++;
                    }
                }
            }







            
            //for (int i = 0, count = 0; i < 12; i++)
            //{
            //    if ((tempArray[i] != tempArray[i + 1])/*&&(tempArray[i]>=0)*/)   //Если раскоментировать, то будем искать только прибыль больше нуля
            //    {                                                                //Сдесь есть баг, так как числа генерятся рандомно, 
            //        reportMassive[count, 0] = tempArray[i];                      // бывает такое что месяцев с положительной прибылью менее трех
            //        count++;                                                     // так как массив предопределен заранее, в этом случае выкидывает исключение
            //    }                                                                // в принципе как решить знаю, если нужно - реализую

            //    if (count > 2) break;
            //}

            for (var i = 0; i < 12; i++)
            {
                for (var j = 0; j < 12; j++)
                {
                    if (reportMassive[i, 0] == massive[j, 3]) reportMassive[i, 1] = massive[j, 0];

                }

            }

            Console.WriteLine("Наименьшая прибыль (Наибольший убыток) по возрастанию по месяцам");

            for (var i = 0; i < 12; i++)
            {
                Console.Write($" {(Months)reportMassive[i, 1]}   ");
                for (var k = 0; k < (10 - (((Months)reportMassive[i, 1]).ToString()).Length); k++) { Console.Write(" "); }
                Console.WriteLine($" {reportMassive[i, 0]}");
            }


            Console.WriteLine("Для продолжения нажмите любую клавишу . . . ");
            Console.ReadKey();
        }
    }
}
