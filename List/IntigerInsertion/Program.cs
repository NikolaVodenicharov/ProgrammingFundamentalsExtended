using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntigerInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oneToNine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("end")) { break; }

                int number = int.Parse(input);
                int firstDigit = FirstDigitOfNumber(number);

                oneToNine.Insert(firstDigit, number);
            }

            Console.WriteLine(String.Join(" ", oneToNine));
        }

        static int FirstDigitOfNumber (int number)
        {
            int firstDigit = 0;

            while (number > 0)
            {
                firstDigit = number % 10;
                number = number / 10;
            }

            return firstDigit;
        }
    }
}
