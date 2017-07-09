using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2.ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            byte nBase = byte.Parse(input[0]);
            string nNumber = input[1];

            List<byte> nNumberList = new List<byte>();
            for (int i = nNumber.Length - 1; i > -1; i--)
            {
                byte num = (byte)Char.GetNumericValue(nNumber[i]);
                nNumberList.Add(num);
            }

            BigInteger finalNumber = 0;
            for (int i = 0; i < nNumberList.Count; i++)
            {
                byte numFromList = nNumberList[i];
                BigInteger nBasePow = BigInteger.Pow(nBase, i);
                finalNumber += numFromList * nBasePow;
            }

            Console.WriteLine(finalNumber);
        }
    }
}
