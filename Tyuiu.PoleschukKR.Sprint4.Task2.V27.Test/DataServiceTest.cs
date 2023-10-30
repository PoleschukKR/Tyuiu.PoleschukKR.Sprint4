using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint4.Task2.V27.Lib;

namespace Tyuiu.PoleschukKR.Sprint4.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalulate()
        {
            DataService ds = new DataService();
            int[] array = {2, 3, 4, 6, 7, 5, 2, 3, 6, 4, 3, 4, 4 };
            int res = ds.Calculate(array);
            int wait = 32;
            Assert.AreEqual(wait, res);
        }
    }
}
