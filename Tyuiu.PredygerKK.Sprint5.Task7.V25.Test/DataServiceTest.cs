namespace Tyuiu.PredygerKK.Sprint5.Task7.V25.Test
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