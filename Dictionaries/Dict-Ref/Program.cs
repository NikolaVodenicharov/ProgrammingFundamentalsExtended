using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var referencedDictionary = new Dictionary<string, int>();

            while (true)
            {
                var inputInfo = Console.ReadLine()
                                .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputInfo[0].Equals("end", StringComparison.InvariantCulture))
                {
                    break;
                }

                var name = inputInfo[0];
                var valueOrSecondName = inputInfo[1];

                if (char.IsDigit(valueOrSecondName[0]))
                {
                    referencedDictionary[name] = int.Parse(valueOrSecondName);
                }
                else if (referencedDictionary.ContainsKey(valueOrSecondName))
                {
                    referencedDictionary[name] = referencedDictionary[valueOrSecondName];
                }
            }

            foreach (var item in referencedDictionary)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
