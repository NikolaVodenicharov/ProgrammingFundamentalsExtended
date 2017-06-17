using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListInHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> leftPart = new List<int>();
            List<int> rightPart = new List<int>();
            SplitInputListToLeftAndRightPart(inputNumbers, leftPart, rightPart);

            List<int> concatenated = new List<int>();
            for (int i = 0; i < leftPart.Count; i++)
            {
                int num = rightPart[i];
                int leftDigit = num / 10;
                int rightDigit = num % 10;

                concatenated.Add(leftDigit);
                concatenated.Add(leftPart[i]);
                concatenated.Add(rightDigit);
            }

            Console.WriteLine(String.Join(" ", concatenated));
        }

        private static void SplitInputListToLeftAndRightPart(List<int> inputNumbers, List<int> leftPart, List<int> rightPart)
        {
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (i < inputNumbers.Count / 2)
                {
                    leftPart.Add(inputNumbers[i]);
                }
                else
                {
                    rightPart.Add(inputNumbers[i]);
                }
            }
        }
    }
}
