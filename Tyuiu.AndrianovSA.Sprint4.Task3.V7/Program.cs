using Tyuiu.AndrianovSA.Sprint4.Task3.V7.Lib;

namespace Tyuiu.AndrianovSA.Sprint4.Task3.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Андрианов С. А. | ИИПб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Андрианов Сергей Александрович | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 9. Подсчитайте количество   *");
            Console.WriteLine("* нечетных элементов во всем массиве.                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] numsArray = new int[5, 5]
            {
                { 9, 6, 9, 3, 7 },
                { 3, 3, 3, 8, 2 },
                { 2, 1, 3, 5, 2 },
                { 6, 2, 3, 2, 5 },
                { 4, 5, 6, 9, 5 }
            };

            Console.WriteLine("Массив:");
            for (int i = 0; i < numsArray.GetLength(0); i++)
            {
                for (int j = 0; j < numsArray.GetLength(1); j++)
                {
                    Console.Write(numsArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Количество нечетных элементов = " + res);
            Console.ReadKey();
        }
    }
}