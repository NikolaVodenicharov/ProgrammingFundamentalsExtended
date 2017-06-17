using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingOfIntigerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintSign(num);
        }

        static void PrintSign (int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
        }
    }
}
