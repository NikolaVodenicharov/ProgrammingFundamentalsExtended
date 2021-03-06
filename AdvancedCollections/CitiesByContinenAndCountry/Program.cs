﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesByContinenAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            var continentCountryCity = new Dictionary<string, Dictionary<string, List<string>>>();
            ReadFromConsoleAddToCollection(continentCountryCity);

            var informationInFormat = new StringBuilder();
            informationInFormat = AddTheDataToFormatedAnswer(continentCountryCity, informationInFormat);

            PrintAnswer(informationInFormat);
        }

        private static void PrintAnswer(StringBuilder formatedAnswer)
        {
            Console.WriteLine(formatedAnswer);
        }

        private static void ReadFromConsoleAddToCollection(Dictionary<string, Dictionary<string, List<string>>> continentCountryCity)
        {
            var numberOfInputLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfInputLines; i++)
            {
                var inputLine = Console.ReadLine().Split();
                var continent = inputLine[0];
                var country = inputLine[1];
                var city = inputLine[2];

                if (!continentCountryCity.ContainsKey(continent))
                {
                    continentCountryCity.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continentCountryCity[continent].ContainsKey(country))
                {
                    continentCountryCity[continent].Add(country, new List<string>());
                }

                continentCountryCity[continent][country].Add(city);
            }
        }

        private static StringBuilder AddTheDataToFormatedAnswer(Dictionary<string, Dictionary<string, List<string>>> continentCountryCity, StringBuilder formatedAnswer)
        {
            foreach (var continent in continentCountryCity)
            {
                formatedAnswer.AppendLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    formatedAnswer.AppendFormat("  {0} -> {1}" + Environment.NewLine
                                                , country.Key
                                                , string.Join(", ", country.Value));
                }
            }

            return formatedAnswer;
        }
    }
}
