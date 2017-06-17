using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            SortedDictionary<int, int> countedNums = new SortedDictionary<int, int>();

            foreach (var num in inputNumbers)
            {
                if (!countedNums.ContainsKey(num))
                {
                    countedNums[num] = 1;
                }
                else
                {
                    countedNums[num] += 1;
                }
            }

            foreach (var pair in countedNums)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
