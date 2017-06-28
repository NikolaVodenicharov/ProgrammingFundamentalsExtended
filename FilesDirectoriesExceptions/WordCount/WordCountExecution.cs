using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class WordCountExecution
{
    static void Main()
    {
        string[] words = File.ReadAllText("../../../Resources/03. Word Count/words.txt")
                         .Split(new char[] { '-', ',', '.', '?', '!', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string[] text = File.ReadAllText("../../../Resources/03. Word Count/text.txt")
                        .Split(new char[] { '-', ',', '.', '?', '!', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //var dick = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        var wordsRepeatCount = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            var counter = 0;

            for (int j = 0; j < text.Length; j++)
            {
                if (words[i].Equals(text[j], StringComparison.InvariantCultureIgnoreCase))
                {
                    counter++;
                }
            }

            wordsRepeatCount[words[i]] = counter;
        }

        foreach (var pair in wordsRepeatCount.OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }
    }
}