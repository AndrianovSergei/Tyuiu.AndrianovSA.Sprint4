using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AndrianovSA.Sprint4.Task0.V23.Lib
{
    public class DataService : ISprint4Task0V23
    {
        public int GetMultOddArrEl(int[] array)
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