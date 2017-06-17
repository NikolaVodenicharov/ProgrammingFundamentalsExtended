using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedPhones
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();

            while (true)
            {
                var inputPhones = Console.ReadLine()
                                   .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputPhones[0].Equals("Over", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }

                bool isFirstElementOfArrayPhoneNumber = IsAllDigits(inputPhones[0]);

                var phoneName = ExtractPhoneName(inputPhones, isFirstElementOfArrayPhoneNumber);
                var phoneNumber = ExtractPhoneNumber(inputPhones, isFirstElementOfArrayPhoneNumber);
                phonebook[phoneName] = phoneNumber;
            }

            var printingFormat = new StringBuilder();
            foreach (var pair in phonebook)
            {
                printingFormat.AppendLine($"{pair.Key} -> {pair.Value}");
            }

            Console.WriteLine(printingFormat);
        }

        private static string ExtractPhoneName(string[] inputPhoneName, bool isFirstElementOfArrayPhoneNumber)
        {
            if (!isFirstElementOfArrayPhoneNumber)
            {
                return inputPhoneName[0];
            }
            else
            {
                return inputPhoneName[1];
            }
        }

        private static string ExtractPhoneNumber(string[] inputPhoneName, bool isFirstElementOfArrayPhoneNumber)
        {
            if (isFirstElementOfArrayPhoneNumber)
            {
                return inputPhoneName[0];
            }
            else
            {
                return inputPhoneName[1];
            }
        }

        private static bool IsAllDigits(string stringForCheking)
        {
            for (int i = 0; i < stringForCheking.Length; i++)
            {
                if (!char.IsDigit(stringForCheking[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
