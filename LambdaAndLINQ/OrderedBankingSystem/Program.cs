using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccountBalance = new Dictionary<string, Dictionary<string, decimal>>();
            ReadFromConsoleAddToCollection(bankAccountBalance);

            var answerInFormat = new StringBuilder();
            AddInfoToAnswerInFormat(bankAccountBalance, answerInFormat);

            PrintAnswer(answerInFormat);
        }

        private static void PrintAnswer(StringBuilder answerInFormat)
        {
            Console.WriteLine(answerInFormat);
        }

        private static void AddInfoToAnswerInFormat(Dictionary<string, Dictionary<string, decimal>> bankAccountBalance, StringBuilder answerInFormat)
        {
            foreach (var pair in bankAccountBalance
                                 .OrderByDescending(x => x.Value.Sum(b => b.Value))
                                 .ThenByDescending(y => y.Value.Values.FirstOrDefault()))
            {
                foreach (var accountBalance in pair.Value.OrderByDescending(x => x.Value))
                {
                    answerInFormat.AppendLine($"{accountBalance.Key} -> {accountBalance.Value} ({pair.Key})");
                }
            }
        }

        private static void ReadFromConsoleAddToCollection(Dictionary<string, Dictionary<string, decimal>> bankAccountBalance)
        {
            while (true)
            {
                var inputLine = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var isTimeToStopLoop = inputLine[0].Equals("end", StringComparison.InvariantCultureIgnoreCase);
                if (isTimeToStopLoop)
                {
                    break;
                }

                var bank = inputLine[0];
                var account = inputLine[1];
                var balance = decimal.Parse(inputLine[2]);

                if (!bankAccountBalance.ContainsKey(bank))
                {
                    bankAccountBalance.Add(bank, new Dictionary<string, decimal>());
                }
                if (!bankAccountBalance[bank].ContainsKey(account))
                {
                    bankAccountBalance[bank][account] = 0;
                }
                bankAccountBalance[bank][account] += balance;
            }
        }
    }
}
