using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsAtOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split(' ');
            List<string> wordsOnEvenPosition = new List<string>();

            for (int i = 0; i < inputWords.Length; i++)
            {
                if (i % 2 == 1)
                {
                    wordsOnEvenPosition.Add(inputWords[i]);
                }
            }

            Console.WriteLine(String.Join("", wordsOnEvenPosition));
        }
    }
}
