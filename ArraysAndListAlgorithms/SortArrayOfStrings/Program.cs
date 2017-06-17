using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = Console.ReadLine().Split(' ').ToList();

            inputs.Sort();

            Console.WriteLine(String.Join(" ", inputs));
        }
    }
}
