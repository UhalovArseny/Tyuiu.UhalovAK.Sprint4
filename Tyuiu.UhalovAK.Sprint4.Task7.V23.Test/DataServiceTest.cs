using Tyuiu.UhalovAK.Sprint4.Task7.V23.Lib;
namespace Tyuiu.UhalovAK.Sprint4.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 3;
            int columns = 3; 
            int[,] mtrx = new int[rows, columns];
            string str = "123252729";
            
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}