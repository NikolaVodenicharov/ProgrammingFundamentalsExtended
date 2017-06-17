using System;
using System.Linq;
using System.Collections.Generic;


class RandomizeWords
{
    static void Main()
    {
        var generator = new Random();
        var words = Console.ReadLine()
                        .Split()
                        .ToArray();
        for (int position = 0; position < words.Length; position++)
        {
            var randomNum = generator.Next(0, words.Length);
            var wordFromPosition = words[position];
            words[position] = words[randomNum];
            words[randomNum] = wordFromPosition;
        }
        Console.WriteLine(string.Join(Environment.NewLine, words));
    }
}

