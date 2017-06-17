using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int growthDays = int.Parse(Console.ReadLine());

            while (grapes.Count >= growthDays)
            {
                for (int day = 0; day < growthDays; day++)
                {
                    grapes[0]++;
                    for (int i = 1; i < grapes.Count - 1; i++)
                    {
                        if ((grapes[i] > grapes[i - 1]) &&
                            (grapes[i] > grapes[i + 1]))
                        {
                            if (grapes[i-1] > 0)
                            {
                                grapes[i]++;
                                grapes[i - 1] -= 2;
                            }

                            if (grapes[i+1] > 0)
                            {
                                grapes[i]++;
                                grapes[i + 1] -=2;
                            }
                        }
                        else
                        {
                            if (grapes[i] > 0)
                            {
                                grapes[i]++;
                            }
                        }
                    }
                    grapes[grapes.Count - 1]++;
                }

                for (int i = 0; i < grapes.Count; i++)
                {
                    if (grapes[i] <= growthDays)
                    {
                        grapes.RemoveAt(i);
                        i--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", grapes));
        }
    }
}
