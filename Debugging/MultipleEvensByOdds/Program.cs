using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int sumOfOddNums = GetSumOfOddDigits(inputNumber);
            int sumOfEvenNums = GetSumOfEvenDigits(inputNumber);
            int multiple = sumOfEvenNums * sumOfOddNums;
            Console.WriteLine(multiple);
        }

        static int GetSumOfOddDigits (int number)
        {
            number = Math.Abs(number);

            int sum = 0;
            while (number != 0)
            {
                byte currentDigit = (byte)(number % 10);
                if (currentDigit % 2 != 0)
                {
                    sum += currentDigit;
                }

                number /= 10;
            }

            return sum;
        }

        static int GetSumOfEvenDigits (int number)
        {
            number = Math.Abs(number);

            int sum = 0;
            while (number != 0)
            {
                byte currentDigit = (byte)(number % 10);
                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }

                number /= 10;
            }

            return sum;
        }
    }
}
