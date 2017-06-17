using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleFormation
{
    /* 
    You are given 3 integer numbers: a, b and c, which will represent the 3 sides of a triangle. Your task is to check whether the triangle is valid.

    If it is, print "Triangle is valid.".
    Otherwise print "Invalid Triangle." and end the program.

    If it is valid, you have to check if it is a right triangle (a2 + b2 == c2).
    If it is a right triangle, print "Triangle has a right angle between sides a and b", depending on which side forms a right angle. If the sides b and c form a right angle, print "Triangle has a right angle between sides b and c", and so on.
    */  

    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (
                ((a + b) > c) &&
                ((a + c) > b) &&
                ((b + c) > a)
                )
            {
                Console.WriteLine("Triangle is valid.");

                if ((a * a + b * b) == c * c)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if ((a * a + c * c) == b * b)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else if ((b * b + c * c) == a * a)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }

            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
