using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MezentsevSE.Sprint3.Task3.V18.Lib;

namespace Tyuiu.MezentsevSE.Sprint3.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "4n5nvf 56 bgy";

            char item = 'n';

            string res = ds.ReplaceNumOnChar(str, item);

            string wait = "nnnnvf nn bgy";

            Assert.AreEqual(wait, res);

        }
    }
}
