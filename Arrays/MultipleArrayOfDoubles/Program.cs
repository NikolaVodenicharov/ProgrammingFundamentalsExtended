using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleArrayOfDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputArr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());

            double[] multipliedArr = new double[inputArr.Length];

            for (int i = 0; i < inputArr.Length; i++)
            {
                multipliedArr[i] = p * inputArr[i];
            }

            Console.WriteLine(String.Join(" ", multipliedArr));
        }
    }
}
