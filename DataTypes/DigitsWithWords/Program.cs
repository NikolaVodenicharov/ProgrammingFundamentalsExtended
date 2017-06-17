using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsWithWords
{
    //Create a program that reads a digit in the form of a word and prints the digit as a number.

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            byte num = 0;

            switch (input)
            {
                //case "zero": num = 0; break;
                case "one": num = 1; break;
                case "two": num = 2; break;
                case "three": num = 3; break;
                case "four": num = 4; break;
                case "five": num = 5; break;
                case "six": num = 6; break;
                case "seven": num = 7; break;
                case "eight": num = 8; break;
                case "nine": num = 9; break;
            }

            Console.WriteLine(num);
        }
    }
}
