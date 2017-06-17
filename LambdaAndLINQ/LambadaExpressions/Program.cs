using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var selectorSelectorObjectProperty = new Dictionary<string, Dictionary<string, string>>();

            while (true)
            {
                var inputLine = Console.ReadLine().Split(new char[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);

                var isTimeToStopLoop = inputLine[0].Equals("lambada", StringComparison.InvariantCultureIgnoreCase);
                if (isTimeToStopLoop)
                {
                    break;
                }

                var isTimeToDance = inputLine[0].Equals("dance", StringComparison.InvariantCultureIgnoreCase);
                if (isTimeToDance)
                {
                    selectorSelectorObjectProperty = selectorSelectorObjectProperty
                        .ToDictionary(selector => selector.Key, selector => selector.Value
                        .ToDictionary(selectorObject => selectorObject.Key, selectorObject => selectorObject.Key + selectorObject.Value));
                    continue;
                }

                AddElementToCollection(selectorSelectorObjectProperty, inputLine);
            }

            foreach (var pair in selectorSelectorObjectProperty)
            {
                foreach (var selectorObjectPropery in pair.Value)
                {
                    Console.WriteLine($"{pair.Key} => {selectorObjectPropery.Key}{selectorObjectPropery.Value}");
                }
            }
        }

        private static void AddElementToCollection(Dictionary<string, Dictionary<string, string>> selectorSelectorObjectProperty, string[] inputLine)
        {
            var selector = inputLine[0];
            var selectorObject = inputLine[1] + ".";
            var property = inputLine[2];

            if (!selectorSelectorObjectProperty.ContainsKey(selector))
            {
                selectorSelectorObjectProperty.Add(selector, new Dictionary<string, string>());
            }
            selectorSelectorObjectProperty[selector][selectorObject] = property;
        }
    }
}
