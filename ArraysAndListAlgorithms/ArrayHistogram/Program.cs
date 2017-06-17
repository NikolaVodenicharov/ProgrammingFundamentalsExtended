using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputText = Console.ReadLine().Split(' ').ToList();
            List<string> words = new List<string>();
            List<int> count = new List<int>();

            for (int i = 0; i < inputText.Count; i++)
            {
                string currentWord = inputText[i];
                int index = FindIndexOfCurrentWordInWordsLists(words, currentWord);

                AddWordsCount(words, count, currentWord, index);
            }

            MySortDescendingTwoList(words, count);
            List<double> percent = PercentOfCount(count);

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine($"{words[i]} -> {count[i]} times ({percent[i]:f2}%)");
            }
        }

        private static List<double> PercentOfCount(List<int> count)
        {
            List<double> percents = new List<double>();
            int sumOfCount = count.Sum();

            for (int i = 0; i < count.Count; i++)
            {
                double currentNum = (double)count[i];
                double percent = (currentNum / sumOfCount) * 100;
                percents.Add(percent);
            }

            return percents;
        }

        private static void AddWordsCount(List<string> words, List<int> count, string currentWord, int index)
        {
            if (index > -1)
            {
                count[index]++;
            }
            else
            {
                words.Add(currentWord);
                count.Add(1);
            }
        }

        private static int FindIndexOfCurrentWordInWordsLists(List<string> words, string currentWord)
        {
            int index = -1;
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Equals(currentWord))
                {
                    index = i;
                    break;
                }
            }

            return index;
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
