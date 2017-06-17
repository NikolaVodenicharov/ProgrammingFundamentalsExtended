using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int minNum = GetMin(num1, num2);
            minNum = GetMin(num3, minNum);
            Console.WriteLine(minNum);
        }

        static int GetMin (int a, int b)
        {
            return Math.Min(a, b);
        }
    }
}
