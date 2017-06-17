using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfGivenElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchedElement = int.Parse(Console.ReadLine());
            int counter = 0;

            foreach (int num in arr)
            {
                if (num == searchedElement)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
