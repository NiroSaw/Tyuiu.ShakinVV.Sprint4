using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShakinVV.Sprint4.Task5.V12.Lib
{
    public class DataService : ISprint4Task5V12
    {
        public int Calculate(int[,] matrix)
        {
            int count = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }

            }
            return count;
        }
    }
}
