using Tyuiu.UhalovAK.Sprint4.Task5.V23.Lib;

namespace Tyuiu.UhalovAK.Sprint4.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas1 = new int[5, 5]{ {2, -5, 1, 7, 5 },

                                         {4, -4, 7, 4, 4 },

                                         {7, -1, 6, 8, 8},

                                         {8, -1, 5, 8, 4 },

                                         {8, -9, 1, 7, 3 }};
            int[,] res = ds.Calculate(mas1);
            int[,] wait =              { {2, 0, 1, 7, 5 },

                                         {4, 0, 7, 4, 4 },

                                         {7, 0, 6, 8, 8},

                                         {8, 0, 5, 8, 4 },

                                         {8, 0, 1, 7, 3 }};
            CollectionAssert.AreEqual(wait, res);
        }
    }
}