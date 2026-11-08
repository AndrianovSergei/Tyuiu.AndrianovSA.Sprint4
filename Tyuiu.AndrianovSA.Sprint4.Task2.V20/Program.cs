using System;
using Tyuiu.AndrianovSA.Sprint4.Task2.V20.Lib;

namespace Tyuiu.AndrianovSA.Sprint4.Task2.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Андрианов С. А. | ИИПб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Андрианов Сергей Александрович | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 2 до 7 подсчитать сумму четных элементов      *");
            Console.WriteLine("* массива.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 16;
            int[] numsArray = new int[len];

            // Заполнение массива случайными числами от 2 до 7 (включительно)
            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(2, 8);
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Сумма четных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}