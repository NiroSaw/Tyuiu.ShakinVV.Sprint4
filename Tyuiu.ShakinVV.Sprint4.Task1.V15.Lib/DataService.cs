using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShakinVV.Sprint4.Task1.V15.Lib
{
    public class DataService : ISprint4Task1V15
    {
        public int Calculate(int[] arr)
        {
            int product = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    product *= arr[i];
                }
            }
            return product;
        }
    }
}
