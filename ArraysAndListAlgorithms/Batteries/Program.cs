using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] batteriesCapacities = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int amountOfHours = int.Parse(Console.ReadLine());

            List<double> batteriesStatus = new List<double>();
            batteriesStatus.AddRange(batteriesCapacities);

            int[] hoursLastedOfBatteries = new int[batteriesCapacities.Length];

            for (int hour = 0; hour < amountOfHours; hour++)
            {
                for (int i = 0; i < batteriesCapacities.Length; i++)
                {
                    if (batteriesStatus[i] > 0)
                    {
                        batteriesStatus[i] -= usagePerHour[i];
                        hoursLastedOfBatteries[i]++;
                    }
                }               
            }

            for (int i = 0; i < batteriesCapacities.Length; i++)
            {
                if (batteriesStatus[i] > 0)
                {
                    double percent = (batteriesStatus[i] / batteriesCapacities[i]) * 100;
                    Console.WriteLine($"Battery {i + 1}: {batteriesStatus[i]:f2} mAh ({percent:f2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {hoursLastedOfBatteries[i]} hours)");
                }
            }
        }
    }
}
