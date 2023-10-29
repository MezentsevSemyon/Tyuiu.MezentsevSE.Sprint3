﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MezentsevSE.Sprint3.Task1.V28.Lib
{
    public class DataService : ISprint3Task1V28
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sValue = 0;
            while (startValue <= stopValue)
            {
                sValue += ((Math.Pow(value, startValue) + 0.25) * Math.Cos(startValue));
                startValue++;
            }
            return Math.Round(sValue, 3);
        }
    }
}
