using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputPlants = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = inputPlants.Length;
            int seasonsCount = 0;
            int daysCount = 0;

            while (true)
            {
                for (int day = 0; day < len; day++)
                {
                    if (inputPlants.Sum() > 0)
                    {
                        daysCount++;
                    }

                    for (int index = 0; index < len; index++)
                    {
                        int plantPower = inputPlants[index];
                        if (plantPower == 0) { continue; }
                        if (day != index)
                        {
                            inputPlants[index] = plantPower - 1;
                        }
                    }
                }

                if (inputPlants.Sum() > 0)
                {
                    seasonsCount++;

                    for (int i = 0; i < len; i++)
                    {
                        int currentPlant = inputPlants[i];
                        if (currentPlant > 0)
                        {
                            inputPlants[i]++;
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            if (seasonsCount == 1)
            {
                Console.WriteLine($"survived {daysCount} days ({seasonsCount} season)");

            }
            else
            {
                Console.WriteLine($"survived {daysCount} days ({seasonsCount} seasons)");
            }
        }
    }
}
