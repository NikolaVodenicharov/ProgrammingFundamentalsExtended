using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnunionLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primal = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToList();
            int numberOfInputLists = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputLists; i++)
            {
                List<int> secondary = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToList();

                primal = RemoveIfContainsAppendIfNotContains(secondary, primal);
            }

            primal.Sort();

            Console.WriteLine(string.Join(" ", primal));
        }

        static List<int> RemoveIfContainsAppendIfNotContains (List<int> numbers, List<int> AppendingRemoovingList)
        {
            foreach (var num in numbers)
            {
                if (AppendingRemoovingList.Contains(num))
                {
                    AppendingRemoovingList.Remove(num);
                }
                else
                {
                    AppendingRemoovingList.Add(num);
                }
            }

            return AppendingRemoovingList;
        }
    }
}
