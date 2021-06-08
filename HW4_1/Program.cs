using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            май,
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
            int[,] massive = new int[12, 4];
            Random r = new Random();
            
            for (var i = 0; i < 12; i++)
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
                            massive[i, j] = massive[i, j - 2] - massive[i, j - 1];
                            break;
                    }
                }              
            }
            //Так как заказчик крупная компания, то и вывод таблицы должен быть красивым)))

            Console.WriteLine("*********************************************************");
            Console.WriteLine("* Месяц     * Доход         * Расход     * Прибыль      *");
            Console.WriteLine("*********************************************************");
            for (var i = 0; i < 12; i++)
            {
                
                Console.Write($"* {(Months)massive[i, 0],-10}");
                //for (var k = 0; k < (10 - (((Months)massive[i, 0]).ToString()).Length); k++) { Console.Write(" "); }
                
                Console.Write($"* {massive[i, 1],-14}");
                //var number = massive[i, 1];
                //int count = 0;
                //if (number < 0) number = -number;
                //while (number > 0)
                //{
                //    number = number / 10;
                //    count++;
                //}
                //for (var k = 0; k < (10 - count); k++) { Console.Write(" "); }

                Console.Write($"* {massive[i, 2],-11}");
                //number = massive[i, 2];
                //count = 0;
                //if (number < 0) number = -number;
                //while (number > 0)
                //{
                //    number = number / 10;
                //    count++;
                //}
                //for (var k = 0; k < (11 - count); k++) { Console.Write(" "); }

                Console.Write($"* {massive[i, 3],-13}");
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
                Console.WriteLine("*");
            }
            Console.WriteLine("*********************************************************");

            // Определение колдичества месяцев с положительной прибылью
            int countMonth = 0;
            for (int i=0; i<12; i++)
            {
                if (massive[i, 3] > 0) countMonth++;
            }
            Console.WriteLine("Количество месяцев с положительной прибылью составляет " + countMonth);

            //определение трех месяцев наименьшей прибылью, при этом месяцы с одинаковой прибылью считаются за один.
            int[] tempArray = new int[12];
            for(var i = 0; i < 12; i++)
            {
                tempArray[i] = massive[i, 3];
            }
            Console.WriteLine("\n\n\n");
            Array.Sort(tempArray);
            for (var i = 0; i < 12; i++)
            {
                
                Console.WriteLine(tempArray[i]);
            }


            Console.WriteLine("Для продолжения нажмите любую клавишу . . . ");
            Console.ReadKey();
        }
    }
}
