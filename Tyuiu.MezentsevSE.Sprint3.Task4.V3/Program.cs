using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MezentsevSE.Sprint3.Task4.V3.Lib;
namespace Tyuiu.MezentsevSE.Sprint3.Task4.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнил: Мезенцев С.Е. | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                                  *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                                                               *");
            Console.WriteLine("* Задание #4                                                                                                 *");
            Console.WriteLine("* Вариант #3                                                                                                 *");
            Console.WriteLine("* Выполнил: Мезенцев С.Е.  | ИИПб-23-2                                                                       *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=(cos(x)+sin(x))/x            *");
            Console.WriteLine("* При х = 0 прервать цикл. Полученные значения суммировать.                                                  *");
            Console.WriteLine("*                                                                                                            *");

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            int startValue = -5;

            int stopValue = 5;

            Console.WriteLine("Начальное значение:" + startValue);

            Console.WriteLine("Конечное значение:" + stopValue);

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            double res = ds.Calculate(startValue, stopValue);
            Console.WriteLine("Сумма:" + res);
            Console.ReadKey();
        }
    }
}
