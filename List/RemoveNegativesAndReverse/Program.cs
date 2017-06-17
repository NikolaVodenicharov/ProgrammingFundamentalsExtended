using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> reversedPositiveNums = new List<int>();

            foreach (var num in inputNums)
            {
                if (num > 0)
                {
                    reversedPositiveNums.Add(num);
                }
            }

            reversedPositiveNums.Reverse();

            if (reversedPositiveNums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", reversedPositiveNums));
            }
        }
    }
}
