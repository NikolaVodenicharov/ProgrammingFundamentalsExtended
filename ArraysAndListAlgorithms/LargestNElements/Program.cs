using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNElements
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputArr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int nElements = int.Parse(Console.ReadLine());

            List<double> sortedNums = new List<double>();

            for (int indexArr = 0; indexArr < inputArr.Length; indexArr++)
            {
                double currentNumArr = inputArr[indexArr];
                bool inserted = false;

                for (int indexList = 0; indexList < sortedNums.Count; indexList++)
                {
                    double currentNumList = sortedNums[indexList];

                    if (currentNumArr > currentNumList)
                    {
                        inserted = true;
                        sortedNums.Insert(indexList, currentNumArr);
                        break;
                    }
                }

                if (!inserted)
                {
                    sortedNums.Add(currentNumArr);
                }
            }

            List<double> answer = new List<double>();
            for (int i = 0; i < nElements; i++)
            {
                answer.Add(sortedNums[i]);
            }

            Console.WriteLine(string.Join(" ", answer));
        }
    }
}
