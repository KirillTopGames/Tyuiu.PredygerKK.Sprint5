using Tyuiu.PredygerKK.Sprint5.Task1.V17.Lib;

namespace Tyuiu.PredygerKK.Sprint5.Task1.V17.Test
{
    [TestClass]
    public class DataService
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