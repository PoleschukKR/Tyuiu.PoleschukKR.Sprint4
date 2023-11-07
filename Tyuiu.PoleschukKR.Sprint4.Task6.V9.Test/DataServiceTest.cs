using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint4.Task6.V9.Lib;

namespace Tyuiu.PoleschukKR.Sprint4.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string[] array = { "Яблоко", "Апельсин", "Киви", "Груша", "Банан", "Мандарин"};
            int res = ds.Calculate(array);
            int wait = 4;
            Assert.AreEqual(wait, res);

        }
    }
}
