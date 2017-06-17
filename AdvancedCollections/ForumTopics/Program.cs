using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            var topicAndTags = new Dictionary<string, HashSet<string>>();
            ReadFromConsoleAddToDictionary(topicAndTags);

            var searchedTags = ReadAndSplit();

            var answerInFormat = new StringBuilder();
            AddToAnswerFilteredTopics(topicAndTags, searchedTags, answerInFormat);

            PrintAnsswer(answerInFormat);
        }

        private static void AddToAnswerFilteredTopics(Dictionary<string, HashSet<string>> topicAndTags, string[] searchedTags, StringBuilder answerInFormat)
        {
            foreach (var topicTagsPair in topicAndTags)
            {
                var tagsCollections = topicTagsPair.Value;
                bool isCollectionContainsSearchedTags = CheckIsCollectionContainsSearchedTags(searchedTags, tagsCollections);

                if (isCollectionContainsSearchedTags)
                {
                    AddTheDataToAnswer(answerInFormat, topicTagsPair, tagsCollections);
                }
            }
        }

        private static void AddTheDataToAnswer(StringBuilder answerInFormat, KeyValuePair<string, HashSet<string>> topicTagsPair, HashSet<string> tagsCollections)
        {
            answerInFormat.AppendFormat("{0} | #{1}"
                                        + Environment.NewLine
                                        , topicTagsPair.Key
                                        , string.Join(", #", tagsCollections));
        }

        private static bool CheckIsCollectionContainsSearchedTags(string[] searchedTags,  HashSet<string> tagsCollections)
        {
            foreach (var tag in searchedTags)
            {
                if (!tagsCollections.Contains(tag))
                {
                    return false;
                }
            }

            return true;
        }

        private static void PrintAnsswer(StringBuilder answerInFormat)
        {
            Console.WriteLine(answerInFormat);
        }

        private static void ReadFromConsoleAddToDictionary(Dictionary<string, HashSet<string>> topicTags)
        {
            while (true)
            {
                string[] inputLine = ReadAndSplit();

                var isTimeToStopLoop = inputLine[0].Equals("filter", StringComparison.InvariantCultureIgnoreCase);
                if (isTimeToStopLoop)
                {
                    break;
                }

                var topic = inputLine[0];
                IfKeyDoesntExistInitializeKeyValuePair(topicTags, topic);
                AddValuesToDictionary(topicTags, inputLine, topic);
            }
        }

        private static string[] ReadAndSplit()
        {
            return Console.ReadLine().Split(new char[] { '-', '>', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private static void AddValuesToDictionary(Dictionary<string, HashSet<string>> topicTags, string[] inputLine, string topic)
        {
            for (int i = 1; i < inputLine.Length; i++)
            {
                topicTags[topic].Add(inputLine[i]);
            }
        }

        private static void IfKeyDoesntExistInitializeKeyValuePair(Dictionary<string, HashSet<string>> collection, string key)
        {
            if (!collection.ContainsKey(key))
            {
                collection.Add(key, new HashSet<string>());
            }
        }
    }
}
