using Tyuiu.UhalovAK.Sprint4.Task6.V12.Lib;
namespace Tyuiu.UhalovAK.Sprint4.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] st = { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };
            string[] res = ds.Calculate(st);
            string[] wait = {  "Украина",  "Молдова" ,  "Эстония"  };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}