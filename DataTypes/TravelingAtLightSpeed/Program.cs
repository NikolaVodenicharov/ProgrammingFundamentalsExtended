using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingAtLightSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inputLightYears = decimal.Parse(Console.ReadLine());
            long oneLightYear = 9450000000000;
            long distancePerSecond = 300000;
            long distancePerMinute = distancePerSecond * 60;
            long distancePerHour = distancePerMinute * 60;
            long distancePerDay = distancePerHour * 24;
            long distancePerWeek = distancePerDay * 7;

            decimal distance = oneLightYear * inputLightYears;

            int weeks = (int) (distance / distancePerWeek);
            decimal remainderAfterDivisionWeek = distance % distancePerWeek;

            byte days = (byte) (remainderAfterDivisionWeek / distancePerDay);
            decimal remainderAfterDivisionDays = remainderAfterDivisionWeek % distancePerDay;

            byte hours = (byte) (remainderAfterDivisionDays / distancePerHour);
            decimal remainderAfterDivisionHour = remainderAfterDivisionDays % distancePerHour;

            byte minutes = (byte) (remainderAfterDivisionHour / distancePerMinute);
            decimal remainderAfterDivisonMinutes = remainderAfterDivisionHour % distancePerMinute;

            byte seconds = (byte) Math.Round(remainderAfterDivisonMinutes / distancePerSecond);

            Console.WriteLine($"{weeks} weeks");
            Console.WriteLine($"{days} days");
            Console.WriteLine($"{hours} hours");
            Console.WriteLine($"{minutes} minutes");
            Console.WriteLine($"{seconds} seconds");
        }
    }
}
