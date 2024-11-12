using Tyuiu.UhalovAK.Sprint4.Task6.V12.Lib;
namespace Tyuiu.UhalovAK.Sprint4.Task6.V12
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
            
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            DataService ds = new DataService();
            string[] st = { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };
            string[] z = ds.Calculate(st);

            for (int i = 0; i <= st.Length - 1; i++)
            {
                Console.WriteLine(st[i]);
            }






            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");




            

            for (int i = 0; i <= z.Length - 1; i++)
            {
                Console.WriteLine(z[i]);
            }

            

            Console.ReadKey();
        }
    }
}