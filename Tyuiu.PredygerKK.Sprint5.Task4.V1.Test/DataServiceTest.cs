using Tyuiu.PredygerKK.Sprint5.Task4.V1.Lib;

namespace Tyuiu.PredygerKK.Sprint5.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool fileexists = fileInfo.Exists;
            bool expect = true;
            Assert.AreEqual(expect, fileexists);
        }
    }
}