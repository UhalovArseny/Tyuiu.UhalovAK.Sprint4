
using Tyuiu.UhalovAK.Sprint4.Task3.V13.Lib;
namespace Tyuiu.UhalovAK.Sprint4.Task3.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Массивы                                                   *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #13                                                               *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");


            DataService ds = new DataService();

            int[,] mas1 = new int[5, 5]{ {4, 7, 4, 2, 1 },

                                         {6, 7, 3, 6, 5 },

                                         {6, 5, 3, 3, 5 },

                                         {4, 4, 6, 4, 7 },

                                         {2, 1, 2, 3, 4 } };









            int z = ds.Calculate(mas1);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}