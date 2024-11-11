using Tyuiu.UhalovAK.Sprint4.Task2.V24.Lib;

namespace Tyuiu.UhalovAK.Sprint4.Task2.V24
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
            DataService ds = new DataService();

            Random rnd = new Random();

            int len;
            len = Convert.ToInt32(Console.ReadLine());
            int[] numArry = new int[len];



            for (int i = 0; i <= len - 1; i++)
            {
                numArry[i] = rnd.Next(4, 9);
            }

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");


            for (int i = 0; i <= len - 1; i++)
            { 
                Console.WriteLine(numArry[i] + "\t"); 
            }


            int z = ds.Calculate(numArry);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}