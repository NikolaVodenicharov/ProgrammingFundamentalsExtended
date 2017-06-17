using System;
using System.Globalization;

class DayOfWeek
{
    static void Main()
    {
        Console.WriteLine
            (DateTime.ParseExact
            (Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture)
            .DayOfWeek);
    }
}

