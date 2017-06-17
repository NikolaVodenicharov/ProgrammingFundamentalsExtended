using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = ReadAndSplitInput();

            List<string> lowerCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();

            AllocatedWordsAccordingCasing(inputWords, lowerCaseWords, mixedCaseWords, upperCaseWords);

            PrintWordsAccordingCasing(lowerCaseWords, mixedCaseWords, upperCaseWords);
        }

        private static void AllocatedWordsAccordingCasing(string[] text, List<string> lowerCase, List<string> mixedCase, List<string> upperCase)
        {
            foreach (var word in text)
            {
                if (word.All(char.IsUpper))
                {
                    upperCase.Add(word);
                }
                else if (word.All(char.IsLower))
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
        }

        private static void PrintWordsAccordingCasing(List<string> lowerCase, List<string> mixedCase, List<string> upperCase)
        {
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + String.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + String.Join(", ", upperCase));
        }

        private static string[] ReadAndSplitInput()
        {
            char[] separator = new char[] { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' ' };

            string[] input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            return input;
        }
    }
}
