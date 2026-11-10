using Tyuiu.ShakinVV.Sprint4.Task7.V1.Lib;

namespace Tyuiu.ShakinVV.Sprint4.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 3;
            int col = 3;
            int[,] mtrx = new int[row, col];
            string str = "135792468";

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Шакин В. В. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Шакин Владимир Вячеславович | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дана строка из одноразрядных цифр 135792468.                            *");
            Console.WriteLine("* Преобразуйте ее в матрицу 3 на 3 и подсчитайте количество четных чисел. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            Console.WriteLine("Массив:");// \n тоже убрал ибо так себе смотрелось
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {

                    Console.Write($"{str[index]}    ");// не хочу \t использовать сорри
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(row, col, str);

            Console.WriteLine($"Количество чётных элементов = {res}");

            Console.ReadKey();
        }
    }
}
