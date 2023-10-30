using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint4.Task1.V28.Lib;

namespace Tyuiu.PoleschukKR.Sprint4.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 2,4,5,5,3,1,1,4,4,3};
            int res = ds.Calculate(array);
            int wait = 225;
            Assert.AreEqual(wait, res);
        }
    }
}
