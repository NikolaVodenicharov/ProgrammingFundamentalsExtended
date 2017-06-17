using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RegisteredUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var register = new Dictionary<string, DateTime>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                var isTimeToStopLoop = inputLine.Equals("end");
                if (isTimeToStopLoop)
                {
                    break;
                }

                var splitedInfo = inputLine.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = splitedInfo[0];
                var date = DateTime.ParseExact(splitedInfo[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!register.ContainsKey(name))
                {
                    register.Add(name, new DateTime());
                }
                register[name] = date;
            }

            if (register.Count >= 5)
            {
                var oldestRegistered = register
                                .OrderByDescending(x => x.Value)
                                .Reverse()
                                .Take(5)
                                .OrderByDescending(x => x.Value)
                                .ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine(string.Join(Environment.NewLine, oldestRegistered.Keys));
            }
            else
            {
                var lessThanFiveRegistered = register
                                            .Reverse()
                                            .OrderByDescending(x => x.Value)
                                            .ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine(string.Join(Environment.NewLine, lessThanFiveRegistered.Keys));
            }
        }
    }
}
