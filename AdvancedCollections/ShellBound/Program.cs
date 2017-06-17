using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellBound
{
    class Program
    {
        static void Main(string[] args)
        {
            var regionAndSizeOfShells = new Dictionary<string, HashSet<int>>();
            ReadFromConsoleAddtoCollection(regionAndSizeOfShells);


            foreach (var shell in regionAndSizeOfShells)
            {
                double giantShell = CalculateGiantShell(shell.Value);

                // print answer
                Console.WriteLine("{0} -> {1} ({2})"
                                    , shell.Key
                                    , string.Join(", ", shell.Value)
                                    , giantShell);
            }
        }

        private static double CalculateGiantShell(HashSet<int> shellValues)
        {
            double giantShell = 0;

            if (shellValues.Count == 1)
            {
                foreach (var value in shellValues)
                {
                    giantShell += value;
                }
            }
            else
            {
                var sumOfShellsSizes = shellValues.Sum();
                var avarageShellSize = shellValues.Average();
                giantShell = Math.Ceiling(sumOfShellsSizes - avarageShellSize);
            }

            return giantShell;
        }

        private static void ReadFromConsoleAddtoCollection(Dictionary<string, HashSet<int>> regionAndSizeOfShells)
        {
            while (true)
            {
                var inputLine = Console.ReadLine().Split();

                var isTimeToStopLoop = inputLine.Contains("Aggregate", StringComparer.CurrentCultureIgnoreCase);
                if (isTimeToStopLoop)
                {
                    break;
                }

                var regionName = inputLine[0];
                if (!regionAndSizeOfShells.ContainsKey(regionName))
                {
                    regionAndSizeOfShells.Add(regionName, new HashSet<int>());
                }

                var regionSize = int.Parse(inputLine[1]);
                regionAndSizeOfShells[regionName].Add(regionSize);
            }
        }
    }
}
