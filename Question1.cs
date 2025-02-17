using System.Reflection.Metadata.Ecma335;

namespace StringWordCount
{
    public class Program
    {
        public static void Main()
        {
            string sentance = "Just an example here move along";
            Console.WriteLine(WordCounter.CountWords(sentance));
        }
    }


    public class WordCounter
    {
        public static int CountWords(string sentance)
        {
            string[] words = sentance.Split(' ', ',');
            return words.Length;
        }
    }




}

