using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> inputInfro = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 0; i < inputInfro.Count - 1; i++)
            {
                double current = inputInfro[i];
                double next = inputInfro[i + 1];
                if (current == next)
                {
                    inputInfro[i] = current + next;
                    inputInfro.RemoveAt(i + 1);

                    if (i > 0)
                    {
                        i -= 2; 
                    }
                    else
                    {
                        i -= 1;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", inputInfro));
        }
    }
}
