using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PredygerKK.Sprint5.Task6.V21.Lib
{
    public class DataService : ISprint5Task6V21
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            string text = File.ReadAllText(path);
            text = text.Replace("тт", "X");
            text = text.Replace("Тт", "X");
            res = text.Count(c => c ==  'X');
            return res;
        }
    }
}
