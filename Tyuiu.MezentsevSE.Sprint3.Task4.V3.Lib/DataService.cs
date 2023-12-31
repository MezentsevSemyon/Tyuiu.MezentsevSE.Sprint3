﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MezentsevSE.Sprint3.Task4.V3.Lib
{
    public class DataService : ISprint3Task4V3
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            int i;
            for (i = startValue; startValue <= stopValue; i++)
            {
                if (i == 0)
                {
                    break;
                }
                res = res + ((Math.Cos(i) + Math.Sin(i)) / i);
            }
            return Math.Round(res, 3);
        }
    }
}
