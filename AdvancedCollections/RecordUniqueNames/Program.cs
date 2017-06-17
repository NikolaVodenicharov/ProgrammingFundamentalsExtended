using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var uniqueNames = new HashSet<string>();

            var numberOfInputLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfInputLines; i++)
            {
                uniqueNames.Add(Console.ReadLine());
            }

            Console.WriteLine();
            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
