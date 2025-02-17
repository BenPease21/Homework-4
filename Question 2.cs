using System.Reflection.Metadata.Ecma335;

namespace StringWordCount
{
    public class Program
    {
        public static void Main()
        {
           string input = Console.ReadLine();
           Console.WriteLine(FlipFirstAndLast.Flipper(input));
        }
    }


    public class FlipFirstAndLast
    {

        public static string Flipper(string sentance)
        {

            string NewString;

            if (sentance.Length < 2) { return "Incompatible."; }

            if (sentance[0] == sentance[sentance.Length - 1]) return "Two's a pair.";


                char[] charArray = sentance.ToCharArray();
                char first = charArray[0];
                char last = charArray[sentance.Length - 1];

                charArray[0] = last;
                charArray[sentance.Length - 1] = first;
                return new string(charArray);


        }
    }




}

