using Tyuiu.PredygerKK.Sprint5.Task0.V27.Lib;

namespace Tyuiu.PredygerKK.Sprint5.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            string path = @"C:\Users\kiril\source\repos\Tyuiu.PredygerKK.Sprint5\Tyuiu.PredygerKK.Sprint5.Task0.V27\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileexists = fileInfo.Exists;
            bool expect = true;
            Assert.AreEqual(expect, fileexists);
        }
    }
}