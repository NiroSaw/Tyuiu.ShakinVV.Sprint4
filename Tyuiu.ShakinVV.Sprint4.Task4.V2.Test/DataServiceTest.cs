using Tyuiu.ShakinVV.Sprint4.Task4.V2.Lib;

//{5 ,3 ,7 ,1 ,3 ,9 ,8 ,7 ,9 ,4}

namespace Tyuiu.ShakinVV.Sprint4.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int numsWaitArray = 44;

            int res = ds.GetSumOddArrEl(numsArray);

            Assert.AreEqual(numsWaitArray, res);
        }
    }
}
