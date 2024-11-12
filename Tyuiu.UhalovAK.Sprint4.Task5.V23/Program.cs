using Tyuiu.UhalovAK.Sprint4.Task5.V23.Lib;
namespace Tyuiu.UhalovAK.Sprint4.Task5.V23
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

            

            int str = Convert.ToInt32(Console.ReadLine());
            int stl = Convert.ToInt32(Console.ReadLine());
            int[,] mtrx = new int[str, stl];

            for (int i = 0; i <= str-1; i++)
            {
                for (int j = 0; j <= stl-1;   j++)
                {
                    mtrx[i, j] = rnd.Next(-4, 8);
                }
            }

           

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");


            for (int i = 0; i <= str - 1; i++)
            {
                for (int j = 0; j <= stl - 1; j++)
                {

                    Console.WriteLine(mtrx[i, j] + "\t");
                }
            }




            int[,] z = ds.Calculate(mtrx);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i <= str - 1; i++)
            {
                for (int j = 0; j <= stl - 1; j++)
                {

                    Console.WriteLine(mtrx[i, j] + "\t");
                }
            }


            //Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}