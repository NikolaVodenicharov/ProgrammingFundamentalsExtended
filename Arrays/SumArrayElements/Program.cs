using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int[] arr = new int[numberOfInputs];

            for (int i = 0; i < numberOfInputs; i++)
            {
                int num = int.Parse(Console.ReadLine());
                arr[i] = num;
            }

            int sum = arr.Sum();
            Console.WriteLine(sum);
        }
    }
}
