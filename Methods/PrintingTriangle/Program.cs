using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            PrintTriangle(inputNumber);
        }

        static void PrintTriangle (int inputNumber)
        {
            PrintTopPartOfTrinangle(inputNumber);
            PrintBottomPartOfTriangle(inputNumber);
        }

        static void PrintTopPartOfTrinangle (int inputNumber)
        {
            for (int row = 1; row <= inputNumber; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write($"{column} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintBottomPartOfTriangle (int inputNumber)
        {
            for (int row = inputNumber - 1; row > 0; row--)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write($"{column} ");
                }
                Console.WriteLine();
            }
        }
    }
}
