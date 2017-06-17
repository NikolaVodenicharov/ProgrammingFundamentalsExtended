using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().ToLower().Split(' ');
            Dictionary<string, int> countWords = new Dictionary<string, int>();

            foreach (var word in inputWords)
            {
                if (countWords.ContainsKey(word))
                {
                    countWords[word]++;
                }
                else
                {
                    countWords[word] = 1;
                }
            }

            List<string> oddWords = new List<string>();
            foreach (var pair in countWords)
            {
                if (pair.Value % 2 == 1)
                {
                    oddWords.Add(pair.Key);
                }
            }

            Console.WriteLine(String.Join(", ", oddWords));
        }
    }
}
