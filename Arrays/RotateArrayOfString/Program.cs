using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split(' ');
            string[] rotatedArr = new string[inputArr.Length];

            for (int i = 0; i < inputArr.Length; i++)
            {
                rotatedArr[i] = inputArr[(inputArr.Length + i - 1) % inputArr.Length];
            }

            Console.WriteLine(String.Join(" ", rotatedArr));
        }
    }
}
