using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());
            string answer = RepeatString(text, repeatCount);
            Console.WriteLine(answer);
        }

        static string RepeatString (string text, int repeatCoung)
        {
            string repeatedString = string.Empty;
            for (int i = 0; i < repeatCoung; i++)
            {
                repeatedString += text;
            }

            return repeatedString;
        }
    }
}
