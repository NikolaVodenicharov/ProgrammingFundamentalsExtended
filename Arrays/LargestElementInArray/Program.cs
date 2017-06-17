using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int[] inputArr = new int[numberOfInputs];

            for (int i = 0; i < numberOfInputs; i++)
            {
                inputArr[i] = int.Parse(Console.ReadLine());
            }

            int largestNum = inputArr.Max();
            Console.WriteLine(largestNum);
        }
    }
}
