namespace DELETEME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //x1 = 29
            //x2 = 7
            //x3 = 5
            //x4 = 6
            //x5 = 3
            //x6 = 377
            //x7 = 4
            //x8 = -2
            //x9 = -2
            //x10 = 245
            //=========
            //10 = 210
            //3 = 4
            //-1 = 5
            //-4 = 61
            //2 = 23
            //36 = -86
            //4 = 16
            //3 = 78
            //25 = 25
            //2(x^4) = 60
            double x = 0;
            string data = File.ReadAllText(@"InPutDataFileTask4V1");
            x = double.Parse(data);
            double result = 2 * x * x + x;
            Console.WriteLine(result);
        }
    }
}
