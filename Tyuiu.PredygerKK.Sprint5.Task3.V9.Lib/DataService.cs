using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PredygerKK.Sprint5.Task3.V9.Lib
{
    public class DataService : ISprint5Task3V9
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();
            string file = "OutPutFileTask3.bin";

            int res = x*x*x/(x*x-1);
            using (BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.Append)))
            {
                writer.Write(res);
            }
            return path;
        }
    }
}
