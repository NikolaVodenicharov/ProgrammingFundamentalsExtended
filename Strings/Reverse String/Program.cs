using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            char[] charedText = inputText.ToArray();
            char[] reversedText = charedText.Reverse().ToArray();
            Console.WriteLine(string.Join("", reversedText));
        }
    }
}
