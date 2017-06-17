using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelsBack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> buildings = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camel = int.Parse(Console.ReadLine());

            int rounds = (buildings.Count - camel) / 2;

            if (rounds == 0)
            {
                Console.WriteLine("already stable: " + string.Join(" ", buildings));
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.Write("remaining: ");
                for (int i = rounds; i < camel + rounds; i++)
                {
                    Console.Write(buildings[i]);
                    if (i + 1 < camel + rounds)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
