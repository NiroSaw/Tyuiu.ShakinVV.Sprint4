using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShakinVV.Sprint4.Task7.V1.Lib
{
    public class DataService : ISprint4Task7V1
    {
        public int Calculate(int row, int col, string str)
        {
            int[,] mtrx = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    mtrx[i, j] = int.Parse(str.Substring(i * col + j, 1));
                }
            }
            int count = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
