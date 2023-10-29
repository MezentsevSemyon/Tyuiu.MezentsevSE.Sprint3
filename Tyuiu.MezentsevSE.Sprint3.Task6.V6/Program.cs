using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MezentsevSE.Sprint3.Task6.V6.Lib;
namespace Tyuiu.MezentsevSE.Sprint3.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнил: Мезенцев С.Е. | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                  *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                                                   *");
            Console.WriteLine("* Задание #6                                                                                                 *");
            Console.WriteLine("* Вариант #6                                                                                                 *");
            Console.WriteLine("* Выполнил: Мезенцев С.Е.   | ИИПб-23-2                                                                      *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [16, 24]               *");
            Console.WriteLine("* количество всех делителей больше 10                                                                        *");
            Console.WriteLine("*                                                                                                            *");

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            int startValue = 16;
            int stopValue = 24;
            Console.WriteLine("Начальное число:" + startValue);

            Console.WriteLine("Конечное число:" + stopValue);

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            Console.WriteLine("Количество делителей больше 10 = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
