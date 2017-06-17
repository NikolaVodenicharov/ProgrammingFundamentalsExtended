using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameAge = new Dictionary<string, int>();
            var nameSalary = new Dictionary<string, double>();
            var namePosition = new Dictionary<string, string>();

            ReadFromConsoleAddToDictionaries(nameAge, nameSalary, namePosition);

            var baseForFiltering = Console.ReadLine();
            var forPrinting = new StringBuilder();
            forPrinting = MakeRequiredFormatForPrinting(nameAge,
                                                        nameSalary,
                                                        namePosition,
                                                        baseForFiltering,
                                                        forPrinting);
            PrintTheAnswer(forPrinting);

        }

        private static void ReadFromConsoleAddToDictionaries(Dictionary<string, int> nameAge, Dictionary<string, double> nameSalary, Dictionary<string, string> namePosition)
        {
            while (true)
            {
                var input = Console.ReadLine()
                            .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                bool isTimeToBreakLoop = input[0].Equals("filter");
                if (isTimeToBreakLoop)
                {
                    break;
                }

                var name = input[0];
                var age = 0;
                var salary = 0.0;

                var secondParameter = input[1];
                if (int.TryParse(secondParameter, out age))
                {
                    if (!nameAge.ContainsKey(name))
                    {
                        nameAge.Add(name, 0);
                    }

                    nameAge[name] = age;
                }
                else if (double.TryParse(secondParameter, out salary))
                {
                    if (!nameSalary.ContainsKey(name))
                    {
                        nameSalary.Add(name, 0);
                    }

                    nameSalary[name] = salary;
                }
                else
                {
                    if (!namePosition.ContainsKey(name))
                    {
                        namePosition.Add(name, null);
                    }

                    namePosition[name] = secondParameter;
                }

            }
        }

        private static void PrintTheAnswer(StringBuilder forPrinting)
        {
            Console.WriteLine(forPrinting);
        }

        private static StringBuilder MakeRequiredFormatForPrinting
           (Dictionary<string, int> nameAge, 
            Dictionary<string, double> nameSalary, 
            Dictionary<string, string> namePosition, 
            string baseForFiltering, 
            StringBuilder forPrinting)
        {
            var frame = new string('=', 20);

            if (baseForFiltering.Equals("Age"))
            {
                foreach (var pair in nameAge)
                {
                    forPrinting.AppendLine($"Name: {pair.Key}");
                    forPrinting.AppendLine($"Age: {pair.Value}");
                    forPrinting.AppendLine(frame);
                }
            }
            else if (baseForFiltering.Equals("Salary"))
            {
                foreach (var pair in nameSalary)
                {
                    forPrinting.AppendLine($"Name: {pair.Key}");
                    forPrinting.AppendLine($"Salary: {pair.Value:f2}");
                    forPrinting.AppendLine(frame);
                }
            }
            else if (baseForFiltering.Equals("Position"))
            {
                foreach (var pair in namePosition)
                {
                    forPrinting.AppendLine($"Name: {pair.Key}");
                    forPrinting.AppendLine($"Position: {pair.Value}");
                    forPrinting.AppendLine(frame);
                }
            }

            return forPrinting;
        }
    }
}
