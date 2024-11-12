using Tyuiu.UhalovAK.Sprint4.Task4.V1.Lib;

namespace Tyuiu.UhalovAK.Sprint4.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Массивы                                                            *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #13                                                               *");
            Console.WriteLine("* Выполнил: Ухалов Арсений Константинович | АСОиУБ-24-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");


            DataService ds = new DataService();
            
            int str = Convert.ToInt32(Console.ReadLine());
            int stl = Convert.ToInt32(Console.ReadLine());
            int[,] mtrx = new int[str, stl];

            for (int i = 0; i <= str; i++)
            {
                for (int j = 0; i <= stl; i++)
                {
                    mtrx[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            






            int z = ds.Calculate(mtrx);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
