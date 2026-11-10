using System.Data;
using Tyuiu.ShakinVV.Sprint4.Task7.V1.Lib;


//Дана строка из одноразрядных цифр "135792468".
//Преобразуйте ее в матрицу 3 на 3
//и подсчитайте количество четных чисел.

namespace Tyuiu.ShakinVV.Sprint4.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            

            int row = 3;
            int col = 3;
            int[,] mtrx = new int[row, col];
            string str = "135792468";
            DataService ds = new DataService();
            int res = ds.Calculate(row, col, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
