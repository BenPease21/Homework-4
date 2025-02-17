using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualBasic;

namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "123";
            Console.WriteLine(StringOrderChecker.IsOrder(msg));
        }
    }

    public class StringOrderChecker
    {
        public static bool IsOrder(string str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] < str[i - 1]) { return false; }

            }

            return true;
        }
    }
}
