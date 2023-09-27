using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KulakovEE.Sprint1.Task5.V2.Lib;

namespace Tyuiu.KulakovEE.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double t = 200;
            var res = 93;
            Assert.AreEqual(res, ds.FahrenheitToСelsius(t));
        }
    }
}
