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
            string[] st = { "������", "�������", "��������", "���������", "�������", "������", "�������" };
            string[] res = ds.Calculate(st);
            string[] wait = {  "�������",  "�������" ,  "�������"  };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}