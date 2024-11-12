using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.UhalovAK.Sprint4.Task3.V13.Lib
{
    public class DataService : ISprint4Task3V13
    {
        public int Calculate(int[,] array)

        {
            int str = 1;
            int stl = 0;
            int rows = array.GetUpperBound(0) + 1; 
            int columns = array.Length / rows;
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                str +=1;
                stl = 0;
                for (int j = 0; j < columns; j++)
                {
                    
                    stl += 1;
                    if (stl ==3) 
                    {
                        count+= array[i,j];
                    }

                    
                }
                
            }
            return count;
        }
    }
}

