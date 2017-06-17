using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            byte index = byte.Parse(Console.ReadLine());
            byte answer = FindNthDigit(number, index);
            Console.WriteLine(answer);
        }

        static byte FindNthDigit (int number, byte index)
        {
            int pow = index - 1;
            number = number / (int)(Math.Pow(10, pow));
            byte digit = (byte) (number % 10);
            return digit;
        }
    }
}
