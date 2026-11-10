namespace ForTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 2, 4, 6, 8 }, { 1, 3, 5, 7 }, { 9, 2, 4, 6 }, { 8, 1, 3, 5 } };
            int count = 0; // ОБЯЗАТЕЛЬНО объявляем счетчик перед циклами

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);


            Console.ReadKey();
        }
    }
}
