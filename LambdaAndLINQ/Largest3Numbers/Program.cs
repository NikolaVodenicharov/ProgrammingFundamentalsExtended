using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var biggest3Numbers = numbers.OrderByDescending(n => n).Take(3);
            Console.WriteLine(string.Join(" ", biggest3Numbers));
        }
    }
}
