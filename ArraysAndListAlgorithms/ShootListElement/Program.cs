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
            List<double> numbers = new List<double>();
            double lastElement = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("stop", StringComparison.InvariantCultureIgnoreCase))
                {
                    PrintTheAnswerIfCommandIsStop(numbers, lastElement);
                    break;
                }
                else if (input.Equals("bang", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastElement}");
                        break;
                    }

                    double firstSmaller = FindFirstNumSmallerThanAverage(numbers);
                    lastElement = FindLastElemen(numbers, lastElement);
                    numbers.Remove(firstSmaller);
                    Console.WriteLine($"shot {firstSmaller}");
                    DecrementAllNumbers(numbers);
                }
                else
                {
                    double number = double.Parse(input);
                    numbers.Insert(0, number);
                }
            }
        }

        private static void PrintTheAnswerIfCommandIsStop(List<double> numbers, double lastElement)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine($"you shot them all. last one was {lastElement}");
            }
            else
            {
                Console.WriteLine("survivors: " + string.Join(" ", numbers));
            }
        }

        private static double FindLastElemen(List<double> numbers, double lastElement)
        {
            if (numbers.Count == 1)
            {
                lastElement = numbers[0];
            }

            return lastElement;
        }

        static double FindFirstNumSmallerThanAverage(List<double> numbers)
        {
            double avarage = numbers.Average();
            double firstSmaller = numbers[0]; //if there is only one number

            foreach (var num in numbers)
            {
                if (num < avarage)
                {
                    firstSmaller = num;
                    break;
                }
            }

            return firstSmaller;
        }

        static void DecrementAllNumbers(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }
    }
}
