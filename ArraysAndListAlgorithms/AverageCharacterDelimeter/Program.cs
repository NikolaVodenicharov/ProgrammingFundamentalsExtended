using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCharacterDelimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            List<char> allChars = AddTextToCharList(inputs);
            double sumOfChars = FindSumOfChars(allChars);
            string delimeter = FindDelimeter(allChars, sumOfChars);

            Console.WriteLine(String.Join($"{delimeter}", inputs));

        }

        private static string FindDelimeter(List<char> allChars, double sumOfChars)
        {
            int averageChar = (int)(sumOfChars / allChars.Count);
            char averageCharConverted = Convert.ToChar(averageChar);
            string delimeter = averageCharConverted.ToString().ToUpper();
            return delimeter;
        }

        private static double FindSumOfChars(List<char> allChars)
        {
            double sumOfChars = 0;
            for (int i = 0; i < allChars.Count; i++)
            {
                char currentChar = allChars[i];
                int numericValue = (int)currentChar;
                sumOfChars += numericValue;
            }

            return sumOfChars;
        }

        private static List<char> AddTextToCharList(string[] inputs)
        {
            List<char> allChars = new List<char>();

            for (int i = 0; i < inputs.Length; i++)
            {
                char[] charedString = inputs[i].ToCharArray();
                allChars.AddRange(charedString);
            }

            return allChars;
        }
    }
}
