using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> baseForExtraction = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> toBeExtracted = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            foreach (var num in baseForExtraction)
            {
                while (toBeExtracted.Contains(num))
                {
                    toBeExtracted.Remove(num);
                }
            }

            int sumOfBaseList = baseForExtraction.Sum();
            int sumOfExtractedList = toBeExtracted.Sum();
            int different = Math.Abs(sumOfBaseList - sumOfExtractedList);

            if (sumOfBaseList == sumOfExtractedList)
            {
                Console.WriteLine($"Yes. Sum: {sumOfBaseList}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {different}");
            }
        }
    }
}
