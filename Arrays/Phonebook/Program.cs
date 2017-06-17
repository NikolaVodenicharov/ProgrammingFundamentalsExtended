using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] usersNames = Console.ReadLine().Split(' ');

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("done"))
                {
                    break;
                }

                for (int i = 0; i < usersNames.Length; i++)
                {
                    if (input.Equals(usersNames[i]))
                    {
                        Console.WriteLine($"{usersNames[i]} -> {phoneNumbers[i]}");
                    }
                }
            }
        }
    }
}
