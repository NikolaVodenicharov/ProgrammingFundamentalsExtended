using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double answer = PoweredNumber(number, power);
            Console.WriteLine(answer);
        }

        static double PoweredNumber (double number, int power)
        {
            double calculation = 1;
            for (int i = 0; i < power; i++)
            {
                calculation *= number;
            }

            return calculation;
        }
    }
}
