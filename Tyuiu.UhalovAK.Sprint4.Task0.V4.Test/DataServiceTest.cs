using Tyuiu.UhalovAK.Sprint4.Task0.V4.Lib;
namespace Tyuiu.UhalovAK.Sprint4.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int res = ds.GetMultEvenArrEl(numsArray);
            int wait = 32;

        }
    }
}