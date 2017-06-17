using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactProductOfRealNumbers
{
    //Write program to enter n numbers and calculate and print their exact product (without rounding).

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal result = 1;

            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                result = result * number;
            }

            Console.WriteLine(result);
        }
    }
}
