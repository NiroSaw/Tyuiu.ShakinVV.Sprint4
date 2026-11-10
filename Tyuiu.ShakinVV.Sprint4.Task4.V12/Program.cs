using Tyuiu.ShakinVV.Sprint4.Task4.V12.Lib;

namespace Tyuiu.ShakinVV.Sprint4.Task4.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Шакин В. В. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы.(ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Шакин Владимир Вячеславович | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 8.                          *");
            Console.WriteLine("* Заменить четные элементы массива на 1.                                  *");
            Console.WriteLine("* 3, 6, 6, 8, 8,                                                          *");
            Console.WriteLine("* 2, 7, 2, 4, 6,                                                          *");
            Console.WriteLine("* 3, 6, 2, 6, 4,                                                          *");
            Console.WriteLine("* 8, 6, 2, 7, 3,                                                          *");
            Console.WriteLine("* 8, 7, 6, 6, 6                                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] mtrx = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Введите элемент [{i},{j}] (от 2 до 8): ");
                    int input;
                    while (!int.TryParse(Console.ReadLine(), out input) || input < 2 || input > 8)
                    {
                        Console.Write("Ошибка! Введите число от 2 до 8: ");
                    }
                    mtrx[i, j] = input;
                }
            }

            Console.WriteLine("\nВведенный массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mtrx[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] res = ds.Calculate(mtrx);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(res[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
