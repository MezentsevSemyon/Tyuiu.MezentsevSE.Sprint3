using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MezentsevSE.Sprint3.Task7.V6.Lib
{
    public class DataService : ISprint3Task7V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mass;
            int len = (stopValue - startValue) + 1;
            mass = new double[len];
            double y;
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((4*x - 0.5) == 0)
                {
                    y = 0;
                    mass[i] = y;
                    i++;
                }
                y = Math.Round(( ((3*Math.Cos(x))/ (4*x - 0.5) ) + Math.Sin(x) - 5*x - 2), 2);
                mass[i] = y;
                i++;
            }
            return mass;
        }
    }
}
