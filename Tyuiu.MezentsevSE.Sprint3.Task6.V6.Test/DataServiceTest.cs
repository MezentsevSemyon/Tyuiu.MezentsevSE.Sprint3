using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MezentsevSE.Sprint3.Task6.V6.Lib;
namespace Tyuiu.MezentsevSE.Sprint3.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 16;

            int stopValue = 24;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 11;

            Assert.AreEqual(wait, res);
        }
    }
}
