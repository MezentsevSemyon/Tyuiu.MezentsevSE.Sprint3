using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MezentsevSE.Sprint3.Task3.V18.Lib;
namespace Tyuiu.MezentsevSE.Sprint3.Task3.V18
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
            Console.WriteLine("* Задание #3                                                                                                 *");
            Console.WriteLine("* Вариант #18                                                                                                *");
            Console.WriteLine("* Выполнил: Мезенцев С.Е.  | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву n в строке.                                                 *");
            Console.WriteLine("*                                                                                                            *");

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************"); 

            string str = "4n5nvf 56 bgy";
            Console.WriteLine("Исходная строка:" + str);

            char item = 'n';
            Console.WriteLine("Заменить все цифры на букву:" + item);

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            string res = ds.ReplaceNumOnChar(str, item);
            Console.WriteLine("Ответ:" + res);
            Console.ReadKey();
        }
    }
}
