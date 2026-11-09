namespace ForTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 8, 4 };
            int product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product = product * arr[i];

            }
            Console.WriteLine(product / 4);
          
            int[] arr1 = { 111, 222, 333, 456, 789 };
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                int a = arr1[i] / 100;
                int b = (arr1[i] / 10) % 10;
                int c = arr1[i] % 10;
                if (a == b && b == c)
                {
                    count += 1;
                }

            }
            Console.WriteLine(count);

            int[] arr2 = { 2, 5, 8, 3, 6, 9 };
            int result = 0;
            for (int i = 0; i < arr2.Length - 1; i++)
            {
                if (arr2[i] < arr2[i + 1])
                {
                    result++; 
                }

            }
            Console.WriteLine(result);

            int[] arr3 = { 2, 4, 6, 8, 9 };
            int sum = 0;
            for (int i = 0; i < arr3.Length; i++)
            {
                sum += arr3[i] * (i + 1);
            }
            Console.WriteLine(result);


            Console.ReadKey();
        }
    }
}
