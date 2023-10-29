using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MezentsevSE.Sprint3.Task2.V19.Lib;

namespace Tyuiu.MezentsevSE.Sprint3.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнил: Мезенцев С.Е. | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                  *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                                                              *");
            Console.WriteLine("* Задание #2                                                                                                 *");
            Console.WriteLine("* Вариант #19                                                                                                *");
            Console.WriteLine("* Выполнил: Мезенцев С.Е.   | ИИПб-23-2                                                                      *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу используя цикл do-while, которая вычисляет сумму ряда по формуле                        *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            int startValue = 1;

            int stopValue = 10;

            Console.WriteLine("Начальное значение:" + startValue);
            Console.WriteLine("Конечное значение :" + stopValue);

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            
            double res = ds.GetSumSeries(startValue, stopValue);

            Console.WriteLine("Сумма ряда =" + res);

            Console.ReadKey();
        }
    }
}
