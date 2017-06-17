using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallesElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double smallestElement = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] < smallestElement)
                {
                    smallestElement = input[i];
                }
            }

            Console.WriteLine(smallestElement);
        }
    }
}
