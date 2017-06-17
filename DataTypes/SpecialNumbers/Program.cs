using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    //A number is special when its sum of digits is 5, 7 or 11. Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not(True / False).

    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i++)
            {
                int currentNumber = i;
                int summedNumber = 0;
                while (currentNumber > 0)
                {
                    summedNumber += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }

                Console.Write($"{i} -> ");
                if ((summedNumber == 5) || (summedNumber == 7) || (summedNumber == 11))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}
