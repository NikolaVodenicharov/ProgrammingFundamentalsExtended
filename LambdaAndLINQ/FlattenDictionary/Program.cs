using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var commodityBrandModel = new Dictionary<string, Dictionary<string, string>>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                var isTimeToStopLoop = inputLine.Equals("end");
                if (isTimeToStopLoop)
                {
                    break;
                }

                var splitedInput = inputLine.Split();
                if (splitedInput[0].Equals("flatten"))
                {
                    FlattenInnerKeyValue(commodityBrandModel, splitedInput);
                }
                else
                {
                    AddToCommodityBrandModel(commodityBrandModel, splitedInput);
                }
            }

            // arange by Key lenght
            commodityBrandModel = commodityBrandModel
                                .OrderByDescending(x => x.Key.Length)
                                .ToDictionary(x => x.Key, x => x.Value);

            var answerInFormat = new StringBuilder();
            AddInfoToAnswerInFormat(commodityBrandModel, answerInFormat);
            PrintAnswer(answerInFormat);

        }

        private static void PrintAnswer(StringBuilder answerInFormat)
        {
            Console.WriteLine(answerInFormat);
        }

        private static void AddInfoToAnswerInFormat(Dictionary<string, Dictionary<string, string>> commodityBrandModel, StringBuilder answerInFormat)
        {
            foreach (var commodity in commodityBrandModel.Keys)
            {
                var num = 1;
                
                // add Key
                answerInFormat.AppendLine(commodity);

                // add not flattened inner KeyValue
                var notFlattenedInnerKeyValue = commodityBrandModel[commodity]
                                                .Where(x => x.Value != "flatten")
                                                .OrderBy(x => x.Key.Length);
                foreach (var pair in notFlattenedInnerKeyValue)
                {
                    answerInFormat.AppendLine($"{num}. {pair.Key} - {pair.Value}");
                    num++;
                }

                // add flatened inner KeyValue
                var flattenedInnerKeyValue = commodityBrandModel[commodity]
                                            .Where(x => x.Value == "flatten");
                foreach (var pair in flattenedInnerKeyValue)
                {
                    answerInFormat.AppendLine($"{num}. {pair.Key}");
                    num++;
                }
            }
        }

        private static void FlattenInnerKeyValue(Dictionary<string, Dictionary<string, string>> commodityBrandModel, string[] splitedInput)
        {
            var key = splitedInput[1];
            commodityBrandModel[key] = commodityBrandModel[key].ToDictionary(x => (x.Key + x.Value), x => "flatten");
        }

        private static void AddToCommodityBrandModel(Dictionary<string, Dictionary<string, string>> commodityBrandModel, string[] splitedInput)
        {
            var commodity = splitedInput[0];
            var brand = splitedInput[1];
            var model = splitedInput[2];

            if (!commodityBrandModel.ContainsKey(commodity))
            {
                commodityBrandModel.Add(commodity, new Dictionary<string, string>());
            }
            commodityBrandModel[commodity][brand] = model;
        }
    }
}
