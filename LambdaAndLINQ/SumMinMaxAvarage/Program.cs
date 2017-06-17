using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMaxAvarage
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var numberOfInputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputLines; i++)
            {
                numbers.Add(
                        int.Parse(
                        Console.ReadLine()));
            }

            var answerInFormat = new StringBuilder();
            answerInFormat.AppendLine($"Sum = {numbers.Sum()}");
            answerInFormat.AppendLine($"Min = {numbers.Min()}");
            answerInFormat.AppendLine($"Max = {numbers.Max()}");
            answerInFormat.Append($"Average = {numbers.Average()}");

            Console.WriteLine(answerInFormat);
        }
    }
}
