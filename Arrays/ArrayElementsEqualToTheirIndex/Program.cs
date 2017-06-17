using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayElementsEqualToTheirIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (i == inputNumbers[i])
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
