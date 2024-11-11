using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.UhalovAK.Sprint4.Task1.V6.Lib
{
    public class DataService : ISprint4Task1V6
    {
        public int Calculate(int[] array)
        {
            int z = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    z *= array[i];
                }
            }
            return z;
        }
    }
}
