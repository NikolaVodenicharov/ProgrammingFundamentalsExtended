using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementVariable
{
    //Write a program to increment a byte variable (starting at 0) n times and print the result. If you detect an overflow (or several), print how many times there was an overflow alongside the variable value. Sounds simple, right?

    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int result = num % 256;
            double overflows = Math.Floor((double)num / 256);

            Console.WriteLine(result);
            if (overflows > 0)
            {
                Console.WriteLine($"Overflowed {overflows} times");

            }
        }
    }
}
