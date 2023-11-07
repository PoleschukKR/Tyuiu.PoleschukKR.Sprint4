using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint4.Task5.V30.Lib;

namespace Tyuiu.PoleschukKR.Sprint4.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5]
            {
                {-1, 3,2,0,3},
                {3,-1,-2,0,1 },
                {4,2,1,-3,-1},
                {-1,-3,3,-2,0},
                {0,1,3,-2,-1}
            };
            int res = ds.Calculate(matrix);
            int wait = 26;
            Assert.AreEqual(wait, res);
        }
    }
}
