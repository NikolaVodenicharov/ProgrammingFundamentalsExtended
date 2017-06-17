using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingInsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    double currentNum = numbers[j];
                    double previousNum = numbers[j - 1];
                    if (currentNum < previousNum)
                    {
                        double temporary = previousNum;
                        numbers[j - 1] = currentNum;
                        numbers[j] = temporary;
                    }

                    j--;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
