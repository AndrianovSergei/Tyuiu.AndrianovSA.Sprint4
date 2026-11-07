using Tyuiu.AndrianovSA.Sprint4.Task0.V23.Lib;

namespace Tyuiu.AndrianovSA.Sprint4.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            int res = ds.GetMultOddArrEl(numsArray);
            int wait = 99225;

            Assert.AreEqual(wait, res);
        }
    }
}