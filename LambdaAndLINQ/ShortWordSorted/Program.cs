using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                        .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            var result = words.Where(w => w.Length < 5).Select(w => w.ToLower()).Distinct().OrderBy(w => w);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
