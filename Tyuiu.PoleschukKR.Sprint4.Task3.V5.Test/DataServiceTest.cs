using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint4.Task3.V5.Lib;

namespace Tyuiu.PoleschukKR.Sprint4.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5]
            {
                {5,6,7,2,3},
                {5,7,2,6,4},
                {3,3,6,8,4},
                {3,6,2,3,8},
                {6,2,6,4,3}
            };

            int res = ds.Calculate(array);
            int wait = 22;
            Assert.AreEqual(wait, res);


        } 
    }
}
