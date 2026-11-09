using Tyuiu.ShakinVV.Sprint4.Task1.V15.Lib;

namespace Tyuiu.ShakinVV.Sprint4.Task1.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArr = { 6, 7, 6, 7, 5, 7, 6, 7, 9, 4, 6, 5, 8, 5 };

            int res = ds.Calculate(numsArr);
            int wait = 41472;

            Assert.AreEqual(wait, res);
        }
    }
}
