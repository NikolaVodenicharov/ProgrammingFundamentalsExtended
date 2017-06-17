using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalSequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = originalSequence.Length / 4;
            var upperLeftPart = originalSequence.Take(k).Reverse().ToArray();
            var upperRightPart = originalSequence.Skip(k * 3).Take(k).Reverse().ToArray();
            var upperPart = upperLeftPart.Concat(upperRightPart).ToArray();
            var downPart = originalSequence.Skip(k).Take(k * 2).ToArray();

            var summed = new int[upperPart.Length];
            for (int i = 0; i < upperPart.Length; i++)
            {
                summed[i] = upperPart[i] + downPart[i];
            }

            Console.WriteLine(string.Join(" ", summed));
        }
    }
}
