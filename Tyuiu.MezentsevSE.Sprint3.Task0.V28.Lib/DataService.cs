using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MezentsevSE.Sprint3.Task0.V28.Lib
{
    public class DataService : ISprint3Task0V28
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double rez = 1;
            int i;
            for (i = startValue; i < stopValue; i++)
            {
               rez *= ((Math.Pow(value, 3) * i) + 2);
            }
            return Math.Round(rez, 3);
        }
    }
}
