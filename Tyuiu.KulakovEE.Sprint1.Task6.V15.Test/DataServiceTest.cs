using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KulakovEE.Sprint1.Task6.V15.Lib;

namespace Tyuiu.KulakovEE.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "ewfwe ef wer wccew";
            bool res = ds.CheckLettersCount(value);
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}
