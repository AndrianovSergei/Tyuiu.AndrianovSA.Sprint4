using Tyuiu.AndrianovSA.Sprint4.Task5.V11.Lib;

namespace Tyuiu.AndrianovSA.Sprint4.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                { -1,  2, -3,  1, -7 },
                { -4, -5,  2, -1,  0 },
                {  1, -2, -3,  2, -5 },
                { -6,  1,  0, -4,  2 },
                { -7, -1,  2, -2, -3 }
            };

            int[,] res = ds.Calculate(matrix);

            int[,] wait = new int[5, 5]
            {
                { -1,  1, -3,  1, -7 },
                { -4, -5,  1, -1,  0 },
                {  1, -2, -3,  1, -5 },
                { -6,  1,  0, -4,  1 },
                { -7, -1,  1, -2, -3 }
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}