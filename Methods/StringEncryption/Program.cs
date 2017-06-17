using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfInputs = byte.Parse(Console.ReadLine());
            StringBuilder encryption = new StringBuilder();

            for (int i = 0; i < numberOfInputs; i++)
            {
                char inputChar = char.Parse(Console.ReadLine());
                byte numberOfChar = (byte)inputChar;

                byte lastDigitOfChar = (byte)(numberOfChar % 10);

                byte firstDigitOfChar = 0;
                if (numberOfChar < 100)
                {
                    firstDigitOfChar = (byte)(numberOfChar / 10);
                }
                else
                {
                    firstDigitOfChar = (byte)(numberOfChar / 100);
                }

                char startingChar = (char)(inputChar + lastDigitOfChar);
                char endingChar =(char)(inputChar - firstDigitOfChar);
                encryption.Append(startingChar);
                encryption.Append(firstDigitOfChar);
                encryption.Append(lastDigitOfChar);
                encryption.Append(endingChar);
            }

            string answer = encryption.ToString();
            Console.WriteLine(answer);
        }
    }
}
