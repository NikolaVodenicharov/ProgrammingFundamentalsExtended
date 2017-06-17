using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeRadioFrequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            List<char> leftChars = new List<char>();
            List<char> rightChars = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                string numDecimal = input[i];
                int[] numbers = numDecimal.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int leftNum = numbers[0];
                if (leftNum != 0)
                {
                    char left = (Char)leftNum;
                    leftChars.Add(left);
                }
 
                int rightNum = numbers[1];
                if (rightNum != 0)
                {
                    char right = (char)rightNum;
                    rightChars.Add(right);
                }
            }

            List<char> answer = new List<char>();
            answer.AddRange(leftChars);

            List<char> reversedRightChars = new List<char>();
            rightChars.Reverse();
            answer.AddRange(rightChars);

            Console.WriteLine(string.Join("", answer));
        }
    }
}
