using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_String
{
    class Program
    {         
        //Create a program that reads a number N. On the next N lines, it reads integers from the ASCII table. The task is to concatenate everything in string format.

        static void Main(string[] args)
        {
            byte numbersOfInputs = byte.Parse(Console.ReadLine());
            string answer = string.Empty;

            for (int i = 0; i < numbersOfInputs; i++)
            {
                byte asciiNumber = byte.Parse(Console.ReadLine());
                char letter = (char)asciiNumber;
                answer += letter;
            }

            Console.WriteLine(answer);
        }
    }
}
