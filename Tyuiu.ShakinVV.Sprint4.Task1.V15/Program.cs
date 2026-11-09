using Tyuiu.ShakinVV.Sprint4.Task1.V15.Lib;

namespace Tyuiu.ShakinVV.Sprint4.Task1.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Шакин В. В. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Шакин Владимир Вячеславович | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 9 подсчитать произведение   *");
            Console.WriteLine("* четных элементов массива.                                               *");
            Console.WriteLine("* С клавиатуры: 6, 7, 6, 7, 5, 7, 6, 7, 9, 4, 6, 5, 8, 5                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите размер массива (например, 14): ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numsArry = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите значение {i + 1}-го элемента массива: ");
                numsArry[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Произведение четных элементов массива = {ds.Calculate(numsArry)}");

            Console.ReadKey();
        }
    }
}
