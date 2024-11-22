using System.Globalization;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PredygerKK.Sprint5.Task4.V1.Lib
{
    public class DataService : ISprint5Task4V1
    {
        public double LoadFromDataFile(string path)
        {
            double res;
            string data = File.ReadAllText(path);
            double x = Convert.ToDouble(data);
            if (Math.Cos(x) == -x)
            {
                res = 0;
            }
            else
            {
                res = (double)1 / (Math.Cos(x) + x) - 4.12 * x;
            }
            string res1 = Convert.ToString(res);
            return double.Parse(res1, CultureInfo.InvariantCulture);
        }
    }
}
