using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PredygerKK.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            double max = 0;
            double res = 1;
            string text = File.ReadAllText(path);
            string[] temp_strings = text.Split(' ');
            List<string> numbers = new List<string>();
            foreach (string s in temp_strings)
            {
                if (int.TryParse(s.Trim(), out int num) && num > max && num % 2 == 0)
                {
                    max = num;
                }
            }
            for (int i = 1; i <= max; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}
