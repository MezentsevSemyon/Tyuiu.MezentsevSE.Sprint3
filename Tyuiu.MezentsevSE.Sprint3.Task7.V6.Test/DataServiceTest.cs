using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MezentsevSE.Sprint3.Task7.V6.Lib;
namespace Tyuiu.MezentsevSE.Sprint3.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;

            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] mass1;
            mass1 = new double[len];
            mass1[0] = 23.92;
            mass1[1] = 18.88;
            mass1[2] = 13.1;
            mass1[3] = 7.24;
            mass1[4] = 1.8;
            mass1[5] = -8;
            mass1[6] = -5.7;
            mass1[7] = -11.26;
            mass1[8] = -17.12;
            mass1[9] = -22.88;
            mass1[10] = -27.92;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(mass1, res);
        }
    }
}
