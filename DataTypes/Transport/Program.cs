using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    //Calculate how many courses will be needed to transport n persons by using 3 vehicles of capacity 4, 8 and 12 respectively. The input holds one line: the number of people n. The vehicles can travel at the same time.

    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            int coursesNumber = 0;

            coursesNumber = (int)Math.Ceiling((double)peopleNumber / 24);
            Console.WriteLine(coursesNumber);
        }
    }
}
