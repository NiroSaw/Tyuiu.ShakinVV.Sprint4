using Tyuiu.ShakinVV.Sprint4.Task3.V15.Lib;

namespace Tyuiu.ShakinVV.Sprint4.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[5, 5]
            {
                {7, 4, 2, 5, 3 },
                {4, 3, 2, 5, 6 },
                {6, 3, 4, 7, 5 },
                {5, 7, 4, 3, 8 },
                {7, 8, 8, 5, 6 }
            };

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
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 9.                          *");
            Console.WriteLine("* Подсчитайте количество нечетных элементов во всем массиве.              *");
            Console.WriteLine("* 7, 4, 2, 5, 3,                                                          *");
            Console.WriteLine("* 4, 3, 2, 5, 6,                                                          *");
            Console.WriteLine("* 6, 3, 4, 7, 5,                                                          *");
            Console.WriteLine("* 5, 7, 4, 3, 8,                                                          *");
            Console.WriteLine("* 7, 8, 8, 5, 6                                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mtrx[i, j] + "  ");//Я убрал \t так как мне не нравится длина пробелов между элементами
                    
                }
                Console.WriteLine();

            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Количество нечетных элементов массива = {ds.Calculate(mtrx)}");

            Console.ReadKey();
        }
    }
}
