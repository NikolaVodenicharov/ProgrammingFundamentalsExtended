using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromTerabytesToBits
{
    //Write program to enter a real number of terabytes and convert it to bits.

    class Program
    {
        static void Main(string[] args)
        {
            double inputTerabytes = double.Parse(Console.ReadLine());
            long terabytesToBits = (long) (Math.Pow(1024, 4) * 8);
            Console.WriteLine(inputTerabytes * terabytesToBits);
        }
    }
}
