using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbersArr = Console.ReadLine().Split(' ');
            string[] phoneNamesArr = Console.ReadLine().Split(' ');

            Dictionary <string, string> phonebook = AddToDictionaryFromArrays(phoneNamesArr, phoneNumbersArr);

            while (true)
            {
                string[] inputs = Console.ReadLine().Split(' ');

                if (inputs[0].Equals("done")) { break; }

                string command = inputs[0];
                string contact = inputs[1]; // name or phone number
                bool contactIsPhoneNumber = DoesStringContainsDigits(contact);
                string phoneNumber = GetPhoneNumber(phonebook, contact, contactIsPhoneNumber);
                List<int> phoneNumberDigits = DigitsFromPhoneNumber(phoneNumber);
                int sumOfDigits = phoneNumberDigits.Sum();
                string key = GetKeyByValue(phonebook, contact);
                string connectingTo = NamePhoneNumberSwitch(phonebook, contact, contactIsPhoneNumber, key); // if its number we have to write the name. If its name we have to write the number.

                if (command.Equals("call"))
                {
                    Console.WriteLine($"calling {connectingTo}...");
                    bool isOdd = isNumberOdd(sumOfDigits);

                    if (isOdd)
                    {
                        Console.WriteLine("no answer");
                    }
                    else
                    {
                        string duration = FromNumberOfSecondsToTime(sumOfDigits);
                        Console.WriteLine($"call ended. duration: {duration}");
                    }
                }
                else if (command.Equals("message"))
                {
                    Console.WriteLine($"sending sms to {connectingTo}...");
                    bool isOdd = isNumberOdd(sumOfDigits);

                    if (isOdd)
                    {
                        Console.WriteLine("busy");
                    }
                    else
                    {
                        Console.WriteLine("meet me there");
                    }
                }
            }

        }

        public static bool isNumberOdd(int number)
        {
            bool isNumOdd = false;
            if (number % 2 != 0)
            {
                isNumOdd = true;
            }

            return isNumOdd;
        }

        public static Dictionary<string, string> AddToDictionaryFromArrays(string[] keyArray, string[] valueArray)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            for (int i = 0; i < keyArray.Length; i++)
            {
                dict[keyArray[i]] = valueArray[i];
            }

            return dict;
        }

        /// i dont know it well
        /// put inf of some seconds and will return it in format mm:ss
        public static string FromNumberOfSecondsToTime(int numberOfSeconds)
        {
            TimeSpan ts = TimeSpan.FromSeconds(numberOfSeconds);
            string time = String.Format(new DateTime(ts.Ticks).ToString("mm:ss"));

            return time;
        }

        public static string GetKeyByValue(Dictionary<string, string> dict, string value)
        {
            string key = string.Empty;

            foreach (var pair in dict)
            {
                if (pair.Value.Equals(value))
                {
                    key = pair.Key;
                }
            }

            return key;
        }

        public static bool DoesStringContainsDigits(string chekingString)
        {
            bool containsDigit = chekingString.Any(char.IsDigit);

            return containsDigit;
        }

        private static List<int> DigitsFromPhoneNumber(string phoneNumber)
        {
            List<int> phoneNumberDigits = new List<int>();

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                char currentChar = phoneNumber[i];
                if (char.IsDigit(currentChar))
                {
                    int digit = (int)Char.GetNumericValue(currentChar);
                    phoneNumberDigits.Add(digit);
                }
            }

            return phoneNumberDigits;
        }

        public static string GetPhoneNumber(Dictionary<string, string> phonebook, string contact, bool isItPhoneNumber)
        {
            string phoneNumber = contact;

            if (!isItPhoneNumber)
            {
                phoneNumber = phonebook[contact];
            }

            return phoneNumber;
        }

        public static string NamePhoneNumberSwitch (Dictionary<string, string> namesNumbers, string inputNameOrNumber, bool contactIsPhoneNumber, string key)
        {
            string oppositeOfNameOrNumber = string.Empty;
            if (contactIsPhoneNumber)
            {
                oppositeOfNameOrNumber = key;
            }
            else
            {
                oppositeOfNameOrNumber = namesNumbers[inputNameOrNumber];
            }

            return oppositeOfNameOrNumber;
        }       
    }
}
