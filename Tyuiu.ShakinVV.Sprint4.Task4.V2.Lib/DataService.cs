using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShakinVV.Sprint4.Task4.V2.Lib
{
    public class DataService : ISprint4Task0V2
    {
        public int GetSumOddArrEl(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}
