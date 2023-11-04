using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PoleschukKR.Sprint4.Task3.V5.Lib
{
    public class DataService : ISprint4Task3V5

    {
        public int Calculate(int[,] array)
        {
            int res = 0;
            int height = array.GetLength(0);
            int width = array.GetLength(1);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x == 0) 
                    {
                        res += array[y,0];
                    }
                }
            }
            return res;
        }
    }
}
