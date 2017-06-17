using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesInHexadecimalFomat
{
    //Write a program that reads a number in hexadecimal format (0x##) convert it to decimal format and prints it.

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int answer = Convert.ToInt32(input, 16);
            Console.WriteLine(answer);
        }
    }
}
