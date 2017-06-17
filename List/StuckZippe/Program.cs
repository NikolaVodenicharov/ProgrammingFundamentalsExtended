using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckZippe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = ReadList();
            List<int> list2 = ReadList();

            int numberOfDigitsInSmallestNum = SmalestDigitNumberFromTwoLists(list1, list2);

            list1 = RemoveNumbersWithMoreDigits(list1, numberOfDigitsInSmallestNum);
            list2 = RemoveNumbersWithMoreDigits(list2, numberOfDigitsInSmallestNum);

            List<int> zippedList = ZipTwoList(list1, list2);

            Console.WriteLine(String.Join(" ", zippedList));
        }

        static List<int> ReadList ()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            return list;
        }

        /// Remove numbers with more digits than the smallest number.
        /// Example 123, 4, 17, 5. 123 and 17 had more digits.
        /// This method use anoter method - countDigitsInNumber.
        /// I am making new list and adding the numberst with smalest digitn count in him. Because its more fast than remove numbers.
        static List<int> RemoveNumbersWithMoreDigits(List<int> incomingList, int numberOfDigitsInSmallestNum)
        {
            List<int> onlySmallestNumbers = new List<int>();
            foreach (var num in incomingList)
            {
                int numberOfDigitsInCurrentNum = countDigitsInNumber(num);

                if (numberOfDigitsInCurrentNum == numberOfDigitsInSmallestNum)
                {
                    onlySmallestNumbers.Add(num);
                }              
            }

            return onlySmallestNumbers;
        }

        static int countDigitsInNumber(int number)
        {

            int counter = 0;
            while (number != 0)
            {
                number = number / 10;
                counter++;
            }

            return counter;
        }

        static List<int> ZipTwoList (List<int> list1, List<int> list2)
        {
            List<int> zippedList = new List<int>();
            int longestList = Math.Max(list1.Count, list2.Count);
            for (int i = 0; i < longestList; i++)
            {
                if (i < list2.Count)
                {
                    zippedList.Add(list2[i]);
                }

                if (i < list1.Count)
                {
                    zippedList.Add(list1[i]);
                }
            }

            return zippedList;
        }

        /// Count the amount of digit in smallest number from two Lists.
        static int SmalestDigitNumberFromTwoLists (List<int> list1, List<int> list2)
        {
            int smallestNumInList1 = list1.Min();
            int smallestNumInList2 = list2.Min();
            int smallestNumFromTwoLists = Math.Min(smallestNumInList1, smallestNumInList2);
            int digitsCount = countDigitsInNumber(smallestNumFromTwoLists);

            return digitsCount;
        }
    }
}
