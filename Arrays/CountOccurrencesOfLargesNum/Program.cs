using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOccurrencesOfLargesNum
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputNums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double threshold = double.Parse(Console.ReadLine());
            int counter = 0;

            foreach (var num in inputNums)
            {
                if (num > threshold)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
