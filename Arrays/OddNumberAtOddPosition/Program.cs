using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumberAtOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int currentNumber = 0;

            for (int i = 1; i < inputNumbers.Length; i += 2)
            {
                currentNumber = inputNumbers[i];

                if (currentNumber % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {currentNumber}");
                }
            }
        }
    }
}
