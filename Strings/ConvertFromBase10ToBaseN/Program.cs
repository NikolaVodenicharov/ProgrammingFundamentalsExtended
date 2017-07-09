using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1.ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            byte inputBase = byte.Parse(inputs[0]);
            BigInteger number = BigInteger.Parse(inputs[1]);

            byte remaining = 0;
            List<byte> convertedBase = new List<byte>();

            while (number > 0)
            {
                remaining = (byte)(number % inputBase);
                convertedBase.Add(remaining);
                number = number / inputBase;
            }

            convertedBase.Reverse();
            Console.WriteLine(string.Join("", convertedBase));
        }
    }
}
