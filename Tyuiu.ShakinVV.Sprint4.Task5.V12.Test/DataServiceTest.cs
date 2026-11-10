using Tyuiu.ShakinVV.Sprint4.Task5.V12.Lib;

namespace Tyuiu.ShakinVV.Sprint4.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5]
            {
                {4, 4, 4, 4, 4 },
                {4, 4, 4, 4, 4 },
                {4, 4, 4, 4, 4 },
                {4, 4, 4, -6, -1},
                {4, 4, 4, -3, 0 }
            };
            int res = ds.Calculate(mas2);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}
