using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PredygerKK.Sprint5.Task7.V25.Lib
{
    public class DataService : ISprint5Task7V25
    {
        public string LoadDataAndSave(string path)
        {
            string path1 = $@"{Path.GetTempPath()}\OutPutDataFileTask7V25.txt";
            string s = File.ReadAllText(path);
            string alph = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            foreach(char c in alph)
            {
                s = s.Replace($"{c}", "");
            }
            s = s.Replace("    .", ".");
            File.WriteAllText(path1, Convert.ToString(s));
            return s;
        }
    }
}