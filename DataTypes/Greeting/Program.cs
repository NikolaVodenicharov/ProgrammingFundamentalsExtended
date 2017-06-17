using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    //Write a program that enters first name, last name and age and prints "Hello, <first name> <last name>. You are <age> years old.". Use interpolated strings.

    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string age = Console.ReadLine();

            Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old");
        }
    }
}
