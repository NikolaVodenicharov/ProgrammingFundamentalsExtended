using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottageScrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var treeTypeHeights = new Dictionary<string, List<decimal>>();
            ReadFromConsoleAddToDict(treeTypeHeights);

            var requiredType = Console.ReadLine();
            var requiredMinHeight = decimal.Parse(Console.ReadLine());

            //calculations
            decimal pricePerMeterRoundedF2 = FindPricePerMeterRoundedF2(treeTypeHeights);

            decimal usedLogs = treeTypeHeights
                        .Where(pair => pair.Key == requiredType)    // string, searched type of tree
                        .SelectMany(pair => pair.Value)             // List<int>
                        .Where(n => n >= requiredMinHeight)         // int >= minimal height of tree
                        .Sum();
            decimal usedLogsPrice = usedLogs * pricePerMeterRoundedF2;

            decimal unusedLogsPrice = FindUnusedLogsPrice(treeTypeHeights, 
                                                        pricePerMeterRoundedF2, 
                                                        usedLogs);

            decimal cottageScraperSubtotal = usedLogsPrice + unusedLogsPrice;

            //add to answer
            var answerInFormat = MakeAnswerInFormat(pricePerMeterRoundedF2,
                                                    usedLogsPrice,
                                                    unusedLogsPrice,
                                                    cottageScraperSubtotal);

            PrintAnswer(answerInFormat);
        }

        private static decimal FindUnusedLogsPrice(Dictionary<string, List<decimal>> treeTypeHeights, decimal pricePerMeterRoundedF2, decimal usedLogs)
        {
            decimal totalLogs = treeTypeHeights
                .SelectMany(x => x.Value)
                .Sum();
            decimal unusedLogs = totalLogs - usedLogs;
            decimal unusedLogsPrice = Math.Round((unusedLogs * pricePerMeterRoundedF2 * 0.25M), 2);
            return unusedLogsPrice;
        }

        private static decimal FindPricePerMeterRoundedF2(Dictionary<string, List<decimal>> treeTypeHeights)
        {
            if (treeTypeHeights.Count > 0)
            {
                decimal pricePerMeter = treeTypeHeights
                    .SelectMany(x => x.Value)
                    .Average();
                return Math.Round(pricePerMeter, 2);
            }

            return 0;
        }

        private static void PrintAnswer(StringBuilder answerInFormat)
        {
            Console.WriteLine(answerInFormat);
        }

        private static StringBuilder MakeAnswerInFormat(decimal roundedPricePerMeter, decimal usedLogsPrice, decimal unusedLogsPrice, decimal cottageScraperSubtotal)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Price per meter: ${roundedPricePerMeter:f2}");
            sb.AppendLine($"Used logs price: ${usedLogsPrice:f2}");
            sb.AppendLine($"Unused logs price: ${unusedLogsPrice:f2}");
            sb.Append($"CottageScraper subtotal: ${cottageScraperSubtotal:f2}");

            return sb;
        }

        private static void ReadFromConsoleAddToDict(Dictionary<string, List<decimal>> treeTypeHeight)
        {
            while (true)
            {
                var inputLine = Console.ReadLine()
                                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();

                var isTimeToStopLoop = inputLine[0].Equals("chop");
                if (isTimeToStopLoop)
                {
                    break;
                }

                var treeType = inputLine[0];
                var treeHeight = decimal.Parse(inputLine[1]);

                if (!treeTypeHeight.ContainsKey(treeType))
                {
                    treeTypeHeight.Add(treeType, new List<decimal>());
                }
                treeTypeHeight[treeType].Add(treeHeight);
            }
        }
    }
}
