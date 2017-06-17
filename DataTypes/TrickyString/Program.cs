using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyString
{
    //You are given a delimiter. On the next line, you will receive a number N. On the next N lines, you will receive strings on each line. Your task is to print the strings, separated by the delimiter. Note: the delimiter and strings could be anything: whitespace and empty strings are acceptable input!

    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            byte numberOfInputs = byte.Parse(Console.ReadLine());
            string answer = string.Empty;

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();
                answer += input;
                if (i < numberOfInputs -1)
                {
                    answer += delimiter;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
