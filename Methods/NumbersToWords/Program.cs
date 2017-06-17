using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfInputs = byte.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                string printedText = string.Empty;

                if ((inputNumber > - 100) && (inputNumber < 100))
                {
                    continue;
                }
                else if (inputNumber > 999)
                {
                    printedText = "too large";
                }
                else if (inputNumber < -999)
                {
                    printedText = "too small";
                }
                else if (inputNumber >= 100)
                {
                    printedText = SayNumberWithWords(inputNumber);
                }
                else if (inputNumber <= - 100)
                {
                    int sendingNumber = inputNumber * (-1);
                    printedText = "minus " + SayNumberWithWords(sendingNumber);
                }

                Console.WriteLine(printedText);
            }
        }

        /// Taking a number between 100 and 999.
        /// Return the word for that number.
        static string SayNumberWithWords(int number)
        {
            StringBuilder makingTheWords = new StringBuilder();

            byte numForHundret = (byte)(number / 100);
            string textForHundret = WordOneToNine(numForHundret);
            makingTheWords.Append(textForHundret);
            makingTheWords.Append("-hundred");

            byte lastTwoDigits = (byte)(number % 100);
            if (lastTwoDigits > 0)
            {
                makingTheWords.Append(" and ");

                if (lastTwoDigits < 10)
                {
                    string textForLastDigit = WordOneToNine(lastTwoDigits);
                    makingTheWords.Append(textForLastDigit);
                }
                else if (!(lastTwoDigits < 10) &&
                    !(lastTwoDigits > 19))
                {
                    string textForLastTwoDigits = WordTenToNineteen(lastTwoDigits);
                    makingTheWords.Append(textForLastTwoDigits);
                }
                else
                {
                    string textOfDigitForTens = WordTwentyToNinety(lastTwoDigits);
                    makingTheWords.Append(textOfDigitForTens);

                    byte firstDigit = (byte)(lastTwoDigits % 10);
                    if (firstDigit > 0)
                    {
                        string textForFirstDigit = WordOneToNine(firstDigit);
                        makingTheWords.Append(" ");
                        makingTheWords.Append(textForFirstDigit);
                    }
                }
            }

            string holeNumberWithWords = makingTheWords.ToString();
            return holeNumberWithWords;
        }

        /// taking a number with 1 digit
        /// return the word for that number
        static string WordOneToNine(byte number)
        {
            string[] oneToNine =
            {
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine"
            }; //array size [9], positions 0-8 (-1)

            byte arrayIndex = (byte)(number - 1);
            string numberWithWord = oneToNine[arrayIndex];
            return numberWithWord;
        }

        /// taking a number with 2 digits between 10 and 19
        /// return the word for that number
        static string WordTenToNineteen(byte number)
        {
            string[] tenToNineteen =
            {
                "ten",
                "eleven",
                "twelve",
                "thirteen",
                "fourteen",
                "fifteen",
                "sixteen",
                "seventeen",
                "eighteen",
                "nineteen"
            }; // array size [10], positios 0-9 (-10)

            byte arrayIndex = (byte)(number % 10);
            string numberWithWord = tenToNineteen[arrayIndex];
            return numberWithWord;
        }

        /// taking a number with 2 digits, betweed 20 and 99
        /// return word for the tens (twenty, fifty)
        static string WordTwentyToNinety(byte number)
        {
            string[] twentyToNinety =
            {
                "twenty",
                "thirty",
                "forty",
                "fifty",
                "sixty",
                "seventy",
                "eighty",
                "ninety"
            }; // array size [8], positions 0-7 (/10, -2)

            byte arrayIndex = (byte)((number / 10) - 2);
            string numberWithWord = twentyToNinety[arrayIndex];
            return numberWithWord;
        }
    }
}
