using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AndrianovSA.Sprint4.Task1.V24.Lib
{
    public class DataService : ISprint4Task1V24
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasOdd = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    product *= array[i];
                    hasOdd = true;
                }
            }

            return hasOdd ? product : 0;
        }
    }
}