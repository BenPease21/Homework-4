using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Function.LetterUpper("abc"));
        }
    }

    public class Function
    {
        public static string LetterUpper(string msg)
        { 
            string vars = "";

            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] == 'a') { vars += 'b'; }
                else if (msg[i] == 'b') { vars += 'c'; }
                else if (msg[i] == 'c') { vars += 'd'; }
                else if (msg[i] == 'd') { vars += 'e'; }
                else if (msg[i] == 'e') { vars += 'f'; }
                else if (msg[i] == 'f') { vars += 'g'; }
                else if (msg[i] == 'g') { vars += 'h'; }
                else if (msg[i] == 'h') { vars += 'i'; }
                else if (msg[i] == 'i') { vars += 'j'; }
                else if (msg[i] == 'j') { vars += 'k'; }
                else if (msg[i] == 'k') { vars += 'l'; }
                else if (msg[i] == 'l') { vars += 'm'; }
                else if (msg[i] == 'm') { vars += 'n'; }
                else if (msg[i] == 'n') { vars += 'o'; }
                else if (msg[i] == 'o') { vars += 'p'; }
                else if (msg[i] == 'p') { vars += 'q'; }
                else if (msg[i] == 'q') { vars += 'r'; }
                else if (msg[i] == 'r') { vars += 's'; }
                else if (msg[i] == 's') { vars += 't'; }
                else if (msg[i] == 't') { vars += 'u'; }
                else if (msg[i] == 'u') { vars += 'v'; }
                else if (msg[i] == 'v') { vars += 'w'; }
                else if (msg[i] == 'w') { vars += 'x'; }
                else if (msg[i] == 'x') { vars += 'y'; }
                else if (msg[i] == 'y') { vars += 'z'; }
                else { vars += msg[i]; } 

            }
            return vars;
        }

    }
}
