using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipListSide
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int switchingLength = (numbers.Count - 2) / 2;

            for (int i = 1; i <= switchingLength; i++)
            {
                int temporarySaveValue = numbers[i];
                numbers[i] = numbers[numbers.Count - 1 - i];
                numbers[numbers.Count - 1 - i] = temporarySaveValue;
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
