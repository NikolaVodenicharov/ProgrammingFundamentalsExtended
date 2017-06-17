using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntigerToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            byte toBase = byte.Parse(Console.ReadLine());
            string answer = IntigerToBase(number, toBase);
            Console.WriteLine(answer);
        }

        static string IntigerToBase (ulong number, byte toBase)
        {
            string result = string.Empty;
            double reminder = 0;
            while (number != 0)
            {
                reminder = number % toBase;
                number = number / toBase;
                result = reminder.ToString() + result;
            }
            return result;
        }
    }
}
