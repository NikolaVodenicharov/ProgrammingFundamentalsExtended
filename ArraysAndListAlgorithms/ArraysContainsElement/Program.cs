using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysContainsElement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> inputNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double num = double.Parse(Console.ReadLine());
            bool isContain = false;

            foreach (var number in inputNumbers)
            {
                if (num == number)
                {
                    isContain = true;
                    break;
                }
            }

            if (isContain)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
