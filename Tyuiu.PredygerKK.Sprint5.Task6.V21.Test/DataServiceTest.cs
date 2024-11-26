using Tyuiu.PredygerKK.Sprint5.Task6.V21.Lib;

namespace Tyuiu.PredygerKK.Sprint5.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int expect = 3;
            string path = Path.GetTempFileName();
            var res = ds.LoadFromDataFile(path);
            Assert.AreEqual(expect, res);
        }

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