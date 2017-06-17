using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last3ConsecutiveStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputText = Console.ReadLine().Split(' ');
            string previousString = string.Empty;
            string currentString = string.Empty;
            byte counter = 1;

            for (int i = inputText.Length - 1; i >= 0; i--)
            {
                currentString = inputText[i];
                if (currentString.Equals(previousString))
                {
                    counter++;
                }
                else
                {
                    previousString = currentString;
                    counter = 1;
                }

                if (counter == 3)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(currentString + " ");
                    }

                    Console.WriteLine();
                    break;
                }
            }

        }
    }
}
