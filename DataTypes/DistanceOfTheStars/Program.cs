using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceOfTheStars
{
    /*  
    In physics, there are some well-known relative distances in Space:
    •	The distance from Earth to its nearest star – Proxima Centauri: ~4.22 ly(light years)
    •	The distance to the center of our galaxy – the Milky Way: ~26 000 ly
    •	The diameter of the Milky Way: ~100 000 ly
    •	The distance from Earth to the edge of the observable universe: ~46 500 000 000 ly
    Write a program to calculate the aforementioned distances in kilometers.
    Print the result using scientific notation with 2 points decimal precision
    Assume that 1 light year == 9 450 000 000 000 km. 
    */

    class Program
    {
        static void Main(string[] args)
        {
            decimal oneLightYear = 9450000000000;
            decimal toNearestStar = (decimal)4.22 * oneLightYear;
            decimal toCenterOfOurGalaxy = 26000 * oneLightYear;
            decimal diameterOfMilkyWay = 100000 * oneLightYear;
            decimal toEdgeOfObservable = 46500000000 * oneLightYear;

            Console.WriteLine(toNearestStar.ToString("0.00e+000", CultureInfo.InvariantCulture));
            Console.WriteLine(toCenterOfOurGalaxy.ToString("0.00e+000", CultureInfo.InvariantCulture));
            Console.WriteLine(diameterOfMilkyWay.ToString("0.00e+000", CultureInfo.InvariantCulture));
            Console.WriteLine(toEdgeOfObservable.ToString("0.00e+000", CultureInfo.InvariantCulture));
        }
    }
}
