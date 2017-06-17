using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfCapitalLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputText = Console.ReadLine().Split(' ');
            int counter = 0;

            foreach (var str in inputText)
            {
                if (str.Length == 1)
                {
                    if (char.IsUpper(str[0]))
                    {
                        counter++;
                    }
                }                
            }

            Console.WriteLine(counter);
        }
    }
}
