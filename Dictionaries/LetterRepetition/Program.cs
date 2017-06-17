using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbolCounter = new Dictionary<char, int>();
            var inputText = Console.ReadLine();

            for (int i = 0; i < inputText.Length; i++)
            {
                var symbol = inputText[i];

                if (!symbolCounter.ContainsKey(symbol))
                {
                    symbolCounter.Add(symbol, 1);
                }
                else
                {
                    symbolCounter[symbol] += 1;
                }
            }

            var printFormat = new StringBuilder();
            foreach (var s in symbolCounter)
            {
                printFormat.AppendLine($"{s.Key} -> {s.Value}");
            }
            Console.WriteLine(printFormat);;
        }
    }
}
