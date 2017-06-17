using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[] charedText = text.ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                int number = nums[i];

                bool isOdd = isNumberOdd(number);

                if (isOdd)
                {
                    charedText[i] = Convert.ToChar(charedText[i] + number);
                }
                else
                {
                    charedText[i] = Convert.ToChar(charedText[i] - number);
                }
            }

            Console.WriteLine(String.Join("", charedText));
            

        }

        public static bool isNumberOdd(int number)
        {
            bool isNumOdd = false;
            if (number % 2 != 0)
            {
                isNumOdd = true;
            }

            return isNumOdd;
        }

    }
}
