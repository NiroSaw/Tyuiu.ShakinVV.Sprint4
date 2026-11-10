using Tyuiu.ShakinVV.Sprint4.Task6.V24.Lib;

namespace Tyuiu.ShakinVV.Sprint4.Task6.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Шакин В. В. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Шакин Владимир Вячеславович | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан строковый массив данных                                             *");
            Console.WriteLine("* [Компьютер, Телефон, Планшет, Принтер, Сканер, Монитор, Клавиатура]     *");
            Console.WriteLine("* используя класс Array, выведите элементы массива,                       *");
            Console.WriteLine("* длина которых больше 7 символов.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] words = new string[] { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };

            Console.WriteLine($"Исходный массив: " + string.Join(", ", words));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string[] result = Array.FindAll(words, x => x.Length > 7);
            Console.WriteLine($"Элементы длинее 7 символов = " + string.Join(", ", result));



            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
