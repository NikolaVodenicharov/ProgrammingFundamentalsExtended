using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputArr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double smallestNum = inputArr.Min();

            Console.WriteLine(smallestNum);
        }
    }
}
