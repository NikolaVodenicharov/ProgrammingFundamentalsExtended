using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            input = MySortAscending(input);

            Console.WriteLine(string.Join(" ", input));
        }

        private static double[] MySortAscending(double[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if (input[j] < input[i])
                    {
                        double temporary = input[i];
                        input[i] = input[j];
                        input[j] = temporary;
                    }
                }
            }

            return input;
        }
    }
}
