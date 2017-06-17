using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> inputNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<int> squareNumbers = new List<int>();

            foreach (var num in inputNumbers)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squareNumbers.Add(Convert.ToInt32(num));
                }
            }

            squareNumbers.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(String.Join(" ", squareNumbers));

        }
    }
}
