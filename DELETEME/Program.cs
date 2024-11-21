namespace DELETEME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double start = -5, end = -3, step = 1;
            string outputfile = "OutPutFileTask1.txt";
            for (double x = start; x <= end; x += step)
            {
                double result = 2 * x + 3 * Math.Pow(x, 2) + 4;
                if(double.IsInfinity(result) || double.IsNaN(result))
                {
                    result = 0;
                }
                result = Math.Round(result, 2);
                File.AppendAllText(outputfile, $"{result} ");
                Console.WriteLine($"{result}");
            }
            File.AppendAllText(outputfile, "\n");
        }
    }
}
