using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            SortedDictionary<double, int> countNumbers = new SortedDictionary<double, int>();

            foreach (var num in inputNumbers)
            {
                if (countNumbers.ContainsKey(num))
                {
                    countNumbers[num]++;
                }
                else
                {
                    countNumbers[num] = 1;
                }
            }

            foreach (var pair in countNumbers)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
