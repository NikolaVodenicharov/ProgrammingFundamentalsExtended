using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split(new char[] { ',', '?', '!', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> result = new List<string>();

            foreach (var word in inputWords.Distinct().OrderBy(x => x))
            {
                bool isPalindrome = true;
                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (!word[i].Equals(word[word.Length - i - 1]))
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                {
                    result.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}

