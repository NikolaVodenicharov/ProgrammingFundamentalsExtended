using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var pairs = new Dictionary<string, string>();
            ReadFromConsoleAddToDict(pairs);

            var inputDefaultValue = Console.ReadLine();
            var notReplaced = pairs
                            .Where(x => x.Value != "null")
                            .OrderByDescending(x => x.Value.Length)
                            .ToDictionary(x => x.Key, x => x.Value);
            var replaced = pairs
                        .Where(x => x.Value == "null")
                        .ToDictionary(x => x.Key, x => inputDefaultValue);

            var answerInFormat = new StringBuilder();
            AppendInformationToAnswer(notReplaced, replaced, answerInFormat);

            PrintAnswer(answerInFormat);

        }

        private static void PrintAnswer(StringBuilder answerInFormat)
        {
            Console.WriteLine(answerInFormat);
        }

        private static void AppendInformationToAnswer(Dictionary<string, string> notReplaced, Dictionary<string, string> replaced, StringBuilder answerInFormat)
        {
            foreach (var pair in notReplaced)
            {
                answerInFormat.AppendLine($"{pair.Key} <-> {pair.Value}");
            }
            foreach (var pair in replaced)
            {
                answerInFormat.AppendLine($"{pair.Key} <-> {pair.Value}");
            }
        }

        private static void ReadFromConsoleAddToDict(Dictionary<string, string> pairs)
        {
            while (true)
            {
                var inputLine = Console.ReadLine();

                var isTimeToStopLoop = inputLine.Equals("end");
                if (isTimeToStopLoop)
                {
                    break;
                }

                var splitedInput = inputLine.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var key = splitedInput[0];
                var value = splitedInput[1];

                if (!pairs.ContainsKey(key))
                {
                    pairs.Add(key, null);
                }
                pairs[key] = value;
            }
        }
    }
}
