using Tyuiu.UhalovAK.Sprint4.Task1.V6.Lib;
namespace Tyuiu.UhalovAK.Sprint4.Task1.V6
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

            
            DataService ds = new DataService();
            int len;
            len = Convert.ToInt32(Console.ReadLine());
            int[] numArry = new int[len];

            

            for (int i = 0; i <= len - 1; i++)
            {
                numArry[i] = Convert.ToInt32(Console.ReadLine());
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
