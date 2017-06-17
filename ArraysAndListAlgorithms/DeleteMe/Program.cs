using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteMe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> value = new List<int>() { 8, 9, 1, 5, 14 };
            List<string> key = new List<string>() { "me", "you", "he", "she", "it" };

            double afterPoint = (83.80 - 83)*1000;
        }

        private static void RemoveFirstNumSmallerThanAverage(List<double> numbers)
        {
            double avarage = numbers.Average();

            for (int i = 0; i < numbers.Count; i++)
            {
                double currentNumber = numbers[i];
                if (currentNumber < avarage)
                {
                    numbers.RemoveAt(i);
                    break;
                }
            }
        }

        static void DecrementAllNumbers (List<double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }

        static double FindFirstNumSmallerThanAverage(List<double> numbers)
        {
            double avarage = numbers.Average();
            double firstSmaller = 0;

            foreach (var num in numbers)
            {
                if (num < avarage)
                {
                    firstSmaller = num;
                    break;
                }
            }

            return firstSmaller;
        }

        static List<int> MySortDescending(List<int> unsorted)
        {
            List<int> sorted = new List<int>();

            for (int u = 0; u < unsorted.Count; u++)
            {
                int numInUnsorted = unsorted[u];

                if (sorted.Count == 0)
                {
                    sorted.Add(numInUnsorted);
                    continue;
                }

                for (int s = 0; s < sorted.Count; s++)
                {
                    int numInSorted = sorted[s];
                    if (numInUnsorted > sorted[s])
                    {
                        sorted.Insert(s, numInUnsorted);
                        break;
                    }

                    if (s + 1 == sorted.Count)
                    {
                        sorted.Add(numInUnsorted);
                        break;
                    }
                }
            }

            return sorted;
        }

        static void MySortDescendingTwoList(List<string> unsortedWords, List<int> unsortedNumbers)
        {
            List<string> sortedWords = new List<string>();
            List<int> sortedNumbers = new List<int>();

            for (int u = 0; u < unsortedNumbers.Count; u++)
            {
                int numInUnsorted = unsortedNumbers[u];
                string wordInUnsorted = unsortedWords[u];

                if (sortedNumbers.Count == 0)
                {
                    sortedNumbers.Add(numInUnsorted);
                    sortedWords.Add(wordInUnsorted);
                    continue;
                }

                for (int s = 0; s < sortedNumbers.Count; s++)
                {
                    int numInSorted = sortedNumbers[s];
                    if (numInUnsorted > sortedNumbers[s])
                    {
                        sortedNumbers.Insert(s, numInUnsorted);
                        sortedWords.Insert(s, wordInUnsorted);
                        break;
                    }

                    if (s + 1 == sortedNumbers.Count)
                    {
                        sortedNumbers.Add(numInUnsorted);
                        sortedWords.Add(wordInUnsorted);
                        break;
                    }
                }
            }

            unsortedWords.Clear();
            unsortedWords.AddRange(sortedWords);

            unsortedNumbers.Clear();
            unsortedNumbers.AddRange(sortedNumbers);
        }

    }
}
