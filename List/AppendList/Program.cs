using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputInfro = Console.ReadLine().Split('|').ToList();
            inputInfro.Reverse();

            List<int> answer = new List<int>();
            foreach (var str in inputInfro)
            {
                List<int> temporary = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                answer.AddRange(temporary);
            }

            Console.WriteLine(String.Join(" ", answer));
        }
    }
}
