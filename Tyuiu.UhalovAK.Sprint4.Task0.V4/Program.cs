using Tyuiu.UhalovAK.Sprint4.Task0.V4.Lib;
namespace Tyuiu.UhalovAK.Sprint4.Task0.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Массивы                                                   *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #4                                                               *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("{ 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 }");
            DataService ds = new DataService();



            int[] numsArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };

            int z = ds.GetMultEvenArrEl(numsArray);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}


