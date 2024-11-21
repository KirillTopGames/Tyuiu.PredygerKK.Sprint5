using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PredygerKK.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempFileName();
            int cnt = 0;
            double y;
            double[] res;
            int len = stopValue - startValue + 1;
            res = new double[len];
            for (int x = -5; x <= 5; x++)
            {
                if (Math.Sin(x) == -1)
                {
                    res[cnt] = 0;
                    continue;
                }
                else
                {
                    y = 2*x - 4 + ((2*x-1)/(Math.Sin(x) + 1));
                    res[cnt] = y;
                }
                cnt++;
                File.WriteAllText(path, Convert.ToString(res) + "\n");
            }
            return path;
        }
    }
}
