using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareSize = int.Parse(Console.ReadLine());
            PrintFilledSquare(squareSize);
        }

        static void PrintFilledSquare (int squareSize)
        {
            PrintTopOrBottomRow(squareSize);
            PrintMiddleRows(squareSize);
            PrintTopOrBottomRow(squareSize);
        }

        static void PrintTopOrBottomRow (int squareSize)
        {
            string topOrBottomRow = new string('-', 2 * squareSize);
            Console.WriteLine(topOrBottomRow);
        }

        static void PrintMiddleRows (int squareSize)
        {
            for (int rows = 0; rows < squareSize - 2; rows++)
            {
                Console.Write("-");
                for (int i = 0; i < squareSize - 1; i++)
                {
                    Console.Write(@"\/");
                }
                Console.WriteLine("-");
            }
         
        }
    }
}
