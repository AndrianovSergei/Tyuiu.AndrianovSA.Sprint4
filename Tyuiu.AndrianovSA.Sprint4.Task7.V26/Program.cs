using Tyuiu.AndrianovSA.Sprint4.Task7.V26.Lib;

namespace Tyuiu.AndrianovSA.Sprint4.Task7.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Андрианов С. А. | ИИПб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Андрианов Сергей Александрович | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"351268459614723\". Преобразуйте ее  *");
            Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n = 5;
            int m = 3;
            string str = "351268459614723";

            Console.WriteLine($"Строка: {str}");
            Console.WriteLine($"Количество строк: {n}");
            Console.WriteLine($"Количество столбцов: {m}");
            Console.WriteLine();

            int[,] matrix = new int[n, m];
            int index = 0;

            Console.WriteLine("Сгенерированная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(str.Substring(index, 1));
                    Console.Write($"{matrix[i, j]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, str);

            Console.WriteLine("Произведение четных элементов = " + res);
            Console.ReadKey();
        }
    }
}