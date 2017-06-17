using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputNums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            bool isIncreasing = false;

            for (int i = 0; i < inputNums.Length - 1; i++)
            {
                double currentNum = inputNums[i];
                double nextNum = inputNums[i + 1];

                if (currentNum < nextNum)
                {
                    isIncreasing = true;
                }
                else
                {
                    isIncreasing = false;
                    break;
                }
            }

            if (isIncreasing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
