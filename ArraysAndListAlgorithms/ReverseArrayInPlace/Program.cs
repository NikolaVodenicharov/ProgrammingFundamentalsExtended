using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayInPlace
{
    class Program
    { 
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length / 2; i++)
            {
                double temporary = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temporary;
            }

            Console.WriteLine(string.Join(" ", input));

        }
    }
}
