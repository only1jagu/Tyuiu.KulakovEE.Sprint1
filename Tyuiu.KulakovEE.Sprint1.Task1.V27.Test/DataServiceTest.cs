
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KulakovEE.Sprint1.Task1.V27.Lib;

namespace Tyuiu.KulakovEE.Sprint1.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 856.0;
            double y = 476.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(666, res);

        }
    }
}
