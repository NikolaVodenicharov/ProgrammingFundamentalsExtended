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
            List<int> appendToThisList = new List<int>()
            {
                1,
                2,
                3,
                4
            };

            List<int> numbers = new List<int>()
            {
                7,
                8,
                9,
                10
            };

            appendToThisList = AppendIfNotContains(numbers, appendToThisList);

        }

        static List<int> AppendIfNotContains(List<int> numbersForAppend, List<int> AppendToThisList)
        {
            foreach (var num in numbersForAppend)
            {
                if (!AppendToThisList.Contains(num))
                {
                    AppendToThisList.Add(num);
                }
            }

            return AppendToThisList;
        }
    }
}
