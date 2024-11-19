using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PredygerKK.Sprint5.Task0.V27.Lib
{
    public class DataService : ISprint5Task0V27
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            double res = Math.Round(Math.Pow(x - 1,3*x + 1), 3);

            File.WriteAllText(path, Convert.ToString(res));
            return path;
        }
    }
}
