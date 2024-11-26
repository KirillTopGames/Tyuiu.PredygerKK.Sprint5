using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;

namespace DELETEME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            string text = "Евофрвтт тт тт тт дывращт олтоты";
            text = text.Replace("тт", "X");
            Console.WriteLine(text);
            res = text.Count(c => c == 'X');
            Console.WriteLine(res);
        }
    }
}
