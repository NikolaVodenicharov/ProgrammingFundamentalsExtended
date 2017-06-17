using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeter
{
    //Write program to enter a radius r (real number) and print the perimeter of a circle with exactly 12 digits after the decimal point.Use data type of enough precision to hold the results.

    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double perimeter = radius * Math.PI * 2;
            Console.WriteLine($"{perimeter:f12}");
        }
    }
}
