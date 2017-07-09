using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            string inputSearchingSubstring = Console.ReadLine().ToLower();

            //int counter = 0;
            //int index = inputText.IndexOf(inputSearchingSubstring);

            //while (!index.Equals(-1))
            //{
            //    counter += 1;
            //    index = inputText.IndexOf(inputSearchingSubstring, index + 1);
            //}

            int counter = -1;
            int index = -1;

            do
            {
                counter += 1;
                index = inputText.IndexOf(inputSearchingSubstring, index + 1);
            } while (!index.Equals(-1));

            Console.WriteLine(counter);
        }
    }
}
