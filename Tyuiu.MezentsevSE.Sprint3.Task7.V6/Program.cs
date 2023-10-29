using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MezentsevSE.Sprint3.Task7.V6.Lib;
namespace Tyuiu.MezentsevSE.Sprint3.Task7.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнил: Мезенцев С.Е. | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                                    *");
            Console.WriteLine("* Задание #7                                                                                                 *");
            Console.WriteLine("* Вариант #6                                                                                                *");
            Console.WriteLine("* Выполнил: Мезенцев С.Е.   | ИИПб-23-2                                                                      *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции                                               *");
            Console.WriteLine("*                                                                                                            *");
            
            
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Начальное значение:" + startValue);
            Console.WriteLine("Конечное значение:" + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] mass;

            mass = new double[len];
            mass = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");




            Console.WriteLine("Массив значений функции - " + "[{0}]", string.Join("; ", mass));
            Console.ReadKey();
        }
    }
}
