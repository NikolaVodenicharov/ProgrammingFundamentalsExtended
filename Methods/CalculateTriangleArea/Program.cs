using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangleBase = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double answer = TriangleAreaCalculation(triangleBase, triangleHeight);
            Console.WriteLine(answer);
        }

        static double TriangleAreaCalculation (double triangleBase, double triangleHeight)
        {
            double triangleArea = (triangleBase * triangleHeight) / 2;
            return triangleArea;
        }
    }
}
