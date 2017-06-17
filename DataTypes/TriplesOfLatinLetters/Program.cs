using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLatinLetters
{
    //Write a program to read an integer n and print all triples of the first n small Latin letters, ordered alphabetically.

    class Program
    {
        static void Main(string[] args)
        {
            int firstNLetters = int.Parse(Console.ReadLine());

            for (char first = 'a'; first < 'a' + firstNLetters; first++)
            {
                for (char second = 'a'; second < 'a' + firstNLetters; second++)
                {
                    for (char third = 'a'; third < 'a' + firstNLetters; third++)
                    {
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
