using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOddNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int currentNum = 0;

            foreach (int num in inputNumbers)
            {
                currentNum = Math.Abs(num);
                if (num % 2 != 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
