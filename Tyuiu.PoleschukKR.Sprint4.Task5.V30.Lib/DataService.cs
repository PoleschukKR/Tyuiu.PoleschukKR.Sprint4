using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PoleschukKR.Sprint4.Task5.V30.Lib
{
    public class DataService : ISprint4Task5V30
    {
        public int Calculate(int[,] matrix)
        {
            int res = 0;
            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (matrix[i,j] >= 0)
                    {
                        res += matrix[i, j];
                    }
                }
            }

            return res;
            
        }
    }
}
