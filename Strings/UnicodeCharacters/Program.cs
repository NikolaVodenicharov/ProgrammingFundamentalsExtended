using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputs = Console.ReadLine().ToArray();

            foreach (var c in inputs)
            {
                Console.Write($"\\u{(int)c:x4}");
            }

            Console.WriteLine();
        }
    }
}
