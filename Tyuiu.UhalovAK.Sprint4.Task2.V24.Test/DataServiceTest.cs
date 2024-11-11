using Tyuiu.UhalovAK.Sprint4.Task2.V24.Lib;
namespace Tyuiu.UhalovAK.Sprint4.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 4, 4, 7, 2, 5, 4, 3, 3, 4 };
            int res = ds.Calculate(numsArray);
            int wait = 18;
            Assert.AreEqual(wait, res);

        }
    }
}