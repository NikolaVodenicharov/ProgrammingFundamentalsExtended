using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSinceBirthday
{
    //Write program to enter an integer number of years and convert it to days, hours and minutes.

    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            int days = years * 365;
            int hours = days * 24;
            int mintues = hours * 60;

            Console.WriteLine($"{years} years = {days} days = {hours} hours = {mintues} minutes");
        }
    }
}
