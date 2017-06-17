using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputInfo = Console.ReadLine().Split(' ');
            long currentAltitude = long.Parse(inputInfo[0]);
            bool isHeCrashed = false;

            for (int i = 1; i < inputInfo.Length; i += 2)
            {
                string direction = inputInfo[i];
                long change = long.Parse(inputInfo[i + 1]);

                if (direction.Equals("up"))
                {
                    currentAltitude += change;
                }
                else if (direction.Equals("down"))
                {
                    currentAltitude -= change;
                }

                if (currentAltitude <= 0)
                {
                    isHeCrashed = true;
                    break;
                }
            }

            if (isHeCrashed)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine($"got through safely. current altitude: {currentAltitude}m");
            }
        }
    }
}
