using System;
using System.Numerics;

class BigFactorial
{
    static void Main()
    {
        BigInteger factorial = 1;
        var inputNum = int.Parse(Console.ReadLine());

        for (int i = 1; i <= inputNum; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine(factorial);
    }
}

