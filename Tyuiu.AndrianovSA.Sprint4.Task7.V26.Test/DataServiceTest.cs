using Tyuiu.AndrianovSA.Sprint4.Task7.V26.Lib;

namespace Tyuiu.AndrianovSA.Sprint4.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            string str = "351268459614723";

            int res = ds.Calculate(n, m, str);
            int wait = 18432;

            Assert.AreEqual(wait, res);
        }
    }
}