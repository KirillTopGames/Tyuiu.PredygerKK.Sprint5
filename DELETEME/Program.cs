namespace DELETEME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputfile = "OutPutFileTask0.txt";
            double x9 = -2;
            double result = 2*Math.Pow(x9, 2) + 3*x9 - 4;
            File.AppendAllText(outputfile, result.ToString());
        }
    }
}
