using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOverflow
{
    //You will be given two numbers. Your task is to find the lowest one by value, find the numerical type it fits in from the following (byte, ushort, uint, ulong) and check how many times the greater one by value overflows the type of the smaller one (rounded to the nearest whole integer).

    class Program
    {
        static void Main(string[] args)
        {
            ulong num1 = ulong.Parse(Console.ReadLine());
            ulong num2 = ulong.Parse(Console.ReadLine());

            decimal smallerNum = Math.Min(num1, num2);
            string smallerNumType = String.Empty;
            decimal smallerNumMaxValue = 0;

            if (!(byte.MinValue > smallerNum) && 
                !(byte.MaxValue < smallerNum))
            {
                smallerNumType = "byte";
                smallerNumMaxValue = byte.MaxValue;
            }
            else if (!(ushort.MinValue > smallerNum) && 
                     !(ushort.MaxValue < smallerNum))
            {
                smallerNumType = "ushort";
                smallerNumMaxValue = ushort.MaxValue;
            }
            else if (!(uint.MinValue > smallerNum) && 
                     !(uint.MaxValue < smallerNum))
            {
                smallerNumType = "uint";
                smallerNumMaxValue = uint.MaxValue;
            }
            else if (!(ulong.MinValue > smallerNum) && 
                     !(ulong.MaxValue < smallerNum))
            {
                smallerNumType = "ulong";
                smallerNumMaxValue = ulong.MaxValue;
            }

            ulong biggerNum = Math.Max(num1, num2);
            string biggerNumType = string.Empty;

            if (!(byte.MinValue > biggerNum) &&
                !(byte.MaxValue < biggerNum))
            {
                biggerNumType = "byte";
            }
            else if (!(ushort.MinValue > biggerNum) &&
                     !(ushort.MaxValue < biggerNum))
            {
                biggerNumType = "ushort";
            }
            else if (!(uint.MinValue > biggerNum) &&
                     !(uint.MaxValue < biggerNum))
            {
                biggerNumType = "uint";
            }
            else if (!(ulong.MinValue > biggerNum) &&
                     !(ulong.MaxValue < biggerNum))
            {
                biggerNumType = "ulong";
            }

            Console.WriteLine($"bigger type: {biggerNumType}");
            Console.WriteLine($"smaller type: {smallerNumType}");
            decimal overflowCount = Math.Round(biggerNum / smallerNumMaxValue);  
            Console.WriteLine($"{biggerNum} can overflow {smallerNumType} {overflowCount} times");
        }
    }
}
