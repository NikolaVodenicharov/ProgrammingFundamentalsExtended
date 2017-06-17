using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFloatingPointNumbers
{
    //Create a new C# project and create a program that assigns floating point values to variables. Be sure that each value is stored in the correct variable type (try to find the most suitable variable type in order to save memory). Finally, you need to print all variables to the console.

    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            decimal num3 = decimal.Parse(Console.ReadLine());

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}
