using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoleschukKR.Sprint4.Task3.V5.Lib;

namespace Tyuiu.PoleschukKR.Sprint4.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Полещук К. Р. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:Двумерные массивы. статический ввод                                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Полещук Кирилл Романович | ИИПб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 9.Найти сумму элем.1 столбца*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[,]
            {
                {3,4,8,6,3},
                {9,9,3,6,9},
                {5,6,7,2,3},
                {3,6,2,3,8},
                {5,7,2,6,4}
            };

            int height = array.GetLength(0);
            int width = array.GetLength(1);
            Console.WriteLine("Массив: ");

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    
                    Console.Write(array[y, x] + "\t");
                }
                Console.WriteLine();
            }
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Cумма элементов первого столбца массива: " + ds.Calculate(array));
            Console.ReadKey();


        }
    }
}
