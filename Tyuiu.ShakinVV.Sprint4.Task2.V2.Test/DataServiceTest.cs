using Tyuiu.ShakinVV.Sprint4.Task2.V2.Lib;

namespace Tyuiu.ShakinVV.Sprint4.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArr = { 1, 2, 3, 5, 7, 8, 6, 6, 3, 1, 3};

            int res = ds.Calculate(numsArr);
            int wait = 945;

            Assert.AreEqual(wait, res);
        }
    }
}
