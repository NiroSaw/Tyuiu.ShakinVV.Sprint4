using Tyuiu.ShakinVV.Sprint4.Task6.V24.Lib;

namespace Tyuiu.ShakinVV.Sprint4.Task6.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string[] words = new string[] { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };
            string[] res = ds.Calculate(words);
            string[] wait = new string[] { "Компьютер", "Клавиатура" };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
