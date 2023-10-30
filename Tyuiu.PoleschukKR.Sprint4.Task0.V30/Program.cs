using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoleschukKR.Sprint4.Task0.V30.Lib;

namespace Tyuiu.PoleschukKR.Sprint4.Task0.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Полещук К. Р. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:Одномерные массивы. Статический ввод                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Полещук Кирилл Романович | ИИПб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("*  статическими значениями в диапазоне от 0 до 9 подсчитать  сумму четных *");
            Console.WriteLine("* элементов массива.  {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            Console.Write("Исходный массив: \t");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + "\t");
            }

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Cумма четных чисел массива \t" + ds.GetSumEvenArrEl(array));
            Console.ReadKey();



        }
    }
}
