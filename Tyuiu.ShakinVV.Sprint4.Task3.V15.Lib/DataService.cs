using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShakinVV.Sprint4.Task3.V15.Lib
{
    public class DataService : ISprint4Task3V15
    {
        public int Calculate(int[,] arr)
        {
            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }

            }
            return count;
        }
    }
}
