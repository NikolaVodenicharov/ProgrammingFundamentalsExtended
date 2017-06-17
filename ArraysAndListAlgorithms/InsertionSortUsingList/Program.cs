using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortUsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputArr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            List<double> answer = new List<double>();

            for (int indexArr = 0; indexArr < inputArr.Length; indexArr++)
            {
                double currentNumArr = inputArr[indexArr];
                bool inserted = false;

                for (int indexList = 0; indexList < answer.Count; indexList++)
                {
                    double currentNumList = answer[indexList];

                    if (currentNumArr <= currentNumList)
                    {
                        inserted = true;
                        answer.Insert(indexList, currentNumArr);
                        break;
                    }
                }

                if (!inserted)
                {
                    answer.Add(currentNumArr);
                }
            }

            Console.WriteLine(string.Join(" ", answer));
        }
    }
}
