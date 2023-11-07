using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoleschukKR.Sprint4.Task4.V14.Lib;

namespace Tyuiu.PoleschukKR.Sprint4.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5,5]  { {2,4,6,1,3},
                                             {1,7,7,3,2},
                                             {4,2,5,7,3},
                                             {2,1,5,6,7},
                                             {4,1,4,6,4} };


            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5,5]  { {2,4,6,0,0},
                                          {0,0,0,0,2},
                                          {4,2,0,0,0},
                                          {2,0,0,6,0},
                                          {4,0,4,6,4} };


            CollectionAssert.AreEqual(wait, res);
        }
    }
}
