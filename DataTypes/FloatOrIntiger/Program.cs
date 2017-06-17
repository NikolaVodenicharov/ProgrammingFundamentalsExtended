using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatOrIntiger
{
    //Write a program that checks whether a number is a real number or an integer number. If the number is an integer, just print the number. If the number is a real number, print the closest integer to it.

    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(num));
        }
    }
}
