using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTShape = int.Parse(Console.ReadLine());

            while (true)
            {
                string currentDirection = Console.ReadLine();

                if (currentDirection == "exit") { break; }

                switch (currentDirection)
                {
                    case "up":
                        PrintUpTShape(sizeOfTShape);
                        break;
                    case "right":
                        PrintRightTShape(sizeOfTShape);
                        break;
                    case "down":
                        PrintDownTShape(sizeOfTShape);
                        break;
                    case "left":
                        PrintLeftTShape(sizeOfTShape);
                        break;
                }
            }
        }

        static void PrintLeftTShape(int n)
        {
            PrintDotAsterisk(n);
            PrintRowsOfAsterisks2N(n);
            PrintDotAsterisk(n);
        }

        static void PrintRightTShape(int n)
        {
            PrintAsteriskDot(n);
            PrintRowsOfAsterisks2N(n);
            PrintAsteriskDot(n);
        }

        static void PrintUpTShape(int n)
        {
            PrintDotAsteriskDot(n);

            PrintRowsOfAsterisks3n(n);
        }

        static void PrintDownTShape(int n)
        {
            PrintRowsOfAsterisks3n(n);

            PrintDotAsteriskDot(n);
        }

        private static void PrintDotAsterisk(int n)
        {
            string point = new string('.', n);
            string asterisk = new string('*', n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(point + asterisk);
            }
        }

        private static void PrintAsteriskDot(int n)
        {
            string point = new string('.', n);
            string asterisk = new string('*', n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(asterisk + point);
            }
        }

        private static void PrintDotAsteriskDot(int n)
        {
            string point = new string('.', n);
            string asterisk = new string('*', n);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(point + asterisk + point);
            }
        }

        private static void PrintRowsOfAsterisks2N(int n)
        {
            string asteriskRow = new string('*', n * 2);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(asteriskRow);
            }
        }

        private static void PrintRowsOfAsterisks3n(int n)
        {
            string asteriskRow3 = new string('*', n * 3);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(asteriskRow3);
            }
        }
    }
}
