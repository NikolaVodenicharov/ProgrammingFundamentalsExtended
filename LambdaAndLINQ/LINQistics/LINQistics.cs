using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class LINQistics
{
    static void Main()
    {
        var collectionMethods = new Dictionary<string, HashSet<string>>();

        var answer = new StringBuilder();

        while (true)
        {
            var inputLine = Console.ReadLine().Split(new char[] { '.', ' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            var isTimeToStopLoop = inputLine[0].Equals("exit", StringComparison.InvariantCultureIgnoreCase);
            if (isTimeToStopLoop)
            {
                break;
            }

            bool isInputContainsOneElement = inputLine.Length == 1;
            bool isInputElementDigit = CheckIsInputElementDigit(inputLine, isInputContainsOneElement);

            if (isInputElementDigit)
            {
                AddMethodsNamesToAnswerByInputNumber(collectionMethods, answer, inputLine);
            }
            else if (isInputContainsOneElement)
            {
                AddMethodsNamesToAnswerByInputKey(collectionMethods, answer, inputLine);
            }
            else
            {
                AddToCollectionMethods(collectionMethods, inputLine);
            }
        }

        var searchedInputLine = Console.ReadLine().Split();
        AddSearchedInfoToAnswer(collectionMethods, answer, searchedInputLine);

        PrintAnswer(answer);
    }

    private static void AddSearchedInfoToAnswer(Dictionary<string, HashSet<string>> collectionMethods, StringBuilder answer, string[] searchedInputLine)
    {
        var searchedMethod = searchedInputLine[0];
        var searchedAllOrCollection = searchedInputLine[1];

        if (searchedAllOrCollection.Equals("all"))
        {
            AddToAnswerSearchedCollectionsMethodsPairs(collectionMethods, answer, searchedMethod);
        }
        else if (searchedAllOrCollection.Equals("collection"))
        {
            AddToAnswerSearchedColletionsNames(collectionMethods, answer, searchedMethod);
        }
    }

    private static void PrintAnswer(StringBuilder answer)
    {
        Console.WriteLine(answer);
    }

    private static void AddToAnswerSearchedCollectionsMethodsPairs(Dictionary<string, HashSet<string>> collectionMethods, StringBuilder answer, string searchedMethod)
    {
        var searchedCollectionMethods = collectionMethods
                                        .Where(v => v.Value.Any(s => s == searchedMethod))
                                        .OrderByDescending(c => c.Value.Count)
                                        .ToDictionary(p => p.Key, p => p.Value);

        foreach (var pair in searchedCollectionMethods)
        {
            answer.AppendLine(pair.Key);
            foreach (var method in pair.Value.OrderByDescending(x => x.Length))
            {
                answer.AppendLine($"* {method}");
            }
        }
    }

    private static void AddToAnswerSearchedColletionsNames(Dictionary<string, HashSet<string>> collectionMethods, StringBuilder answer, string searchedMethod)
    {
        var namesOfCollections = collectionMethods
                                .Where(v => v.Value.Any(s => s == searchedMethod))
                                .OrderByDescending(c => c.Value.Count)
                                .ThenByDescending(m => m.Value.Min(l => l.Length))
                                .Select(k => k.Key)
                                .ToList();

        foreach (var nameOfCollection in namesOfCollections)
        {
            answer.AppendLine(nameOfCollection);
        }
    }

    private static bool CheckIsInputElementDigit(string[] inputLine, bool isInputContainsOneElement)
    {
        var isInputElementDigit = false;
        if (isInputContainsOneElement)
        {
            isInputElementDigit = char.IsDigit(inputLine[0][0]);
        }

        return isInputElementDigit;
    }

    private static void AddMethodsNamesToAnswerByInputNumber(Dictionary<string, HashSet<string>> collectionMethods, StringBuilder answer, string[] inputLine)
    {
        var isCollectionNotEmpty = collectionMethods.Count > 0;
        if (isCollectionNotEmpty)
        {
            var requiredNumberOfMethodsForAdding = int.Parse(inputLine[0]);
            var methodsOfBiggestCollection = collectionMethods
                                    .OrderByDescending(x => x.Value.Count)
                                    .Select(y => y.Value)
                                    .First()
                                    .OrderBy(z => z.Length)
                                    .ToList();
            var realNumberOfMethodsForAdding = Math.Min(requiredNumberOfMethodsForAdding,
                                                        methodsOfBiggestCollection.Count);

            for (int i = 0; i < realNumberOfMethodsForAdding; i++)
            {
                answer.AppendLine($"* {methodsOfBiggestCollection[i]}");
            }
        }
    }

    private static void AddMethodsNamesToAnswerByInputKey(Dictionary<string, HashSet<string>> collectionMethods, StringBuilder answer, string[] inputLine)
    {
        var nameOfCollection = inputLine[0];
        if (collectionMethods.ContainsKey(nameOfCollection))
        {
            foreach (var method in collectionMethods[nameOfCollection]
                                    .OrderByDescending(x => x.Length)
                                    .ThenByDescending(y => y.ToCharArray().Distinct().Count()))
            {
                answer.AppendLine($"* {method}");
            }
        }
    }

    private static void AddToCollectionMethods(Dictionary<string, HashSet<string>> collectionMethods, string[] inputLine)
    {
        var nameOfCollection = inputLine[0];
        if (!collectionMethods.ContainsKey(nameOfCollection))
        {
            collectionMethods.Add(nameOfCollection, new HashSet<string>());
        }

        for (int i = 1; i < inputLine.Length; i++)
        {
            collectionMethods[nameOfCollection].Add(inputLine[i]);
        }
    }
}
