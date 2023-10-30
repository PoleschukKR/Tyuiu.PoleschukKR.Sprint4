using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint4.Task0.V30.Lib;
namespace Tyuiu.PoleschukKR.Sprint4.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = {2,3,8,9,4};
            int res = ds.GetSumEvenArrEl(array);
            int wait = 14;
            Assert.AreEqual(wait, res);
        }
    }
}
