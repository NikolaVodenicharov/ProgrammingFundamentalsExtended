using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /*
    Create a program that reads 3 lines:
    •	An operand.
    •	An operator.
    •	A second operand.
    And performs the operation between the operands. The left and right operands will always be integers.
    */
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string actionBetweenNums = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            int answer = 0;

            switch (actionBetweenNums)
            {
                case "+":
                    answer = num1 + num2;
                    break;
                case "-":
                    answer = num1 - num2;
                    break;
                case "*":
                    answer = num1 * num2;
                    break;
                case "/":
                    answer = num1 / num2;
                    break;
                case "%":
                    answer = num1 % num2;
                    break;
            }

            Console.WriteLine($"{num1} {actionBetweenNums} {num2} = {answer}");

        }
    }
}
