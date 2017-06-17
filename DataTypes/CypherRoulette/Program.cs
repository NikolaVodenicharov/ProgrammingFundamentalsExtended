using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CypherRoulette_TryAgain
{
    /*
    You will be given an integer N. On the next N lines, you will receive some strings.
    The strings will be either:
    •	sequences of random characters
    •	or the command - "spin"

    If they are normal random characters, you should append them to one another in the cypher string.
    If the command "spin" is entered, every string entered after it should be appended at the start
    of the cypher string, if the command "spin" is entered again after that, you should again begin to append them at the end of the cypher string. And so, the append direction changes each time you enter the command "spin".
    If two equal strings are entered two consecutive times, the cypher resets - emptying the cypher string. This rule also applies to the "spin" command.
    Note: the "spin" commands do not count towards the N count. 
    */

    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfImputs = byte.Parse(Console.ReadLine());
            string previousInput = string.Empty;
            string appendedText = string.Empty;
            string appendingDirection = "atEnd"; // "atStart" or "atEnd", depends of "spin".

            for (int i = 0; i < numberOfImputs; i++)
            {
                string currentInput = Console.ReadLine();

                if (currentInput == previousInput)
                {
                    appendedText = string.Empty;
                    if (currentInput == "spin")
                    {
                        i--;
                    }
                    continue;
                }

                if (currentInput == "spin")
                {
                    if (appendingDirection == "atStart")
                    {
                        appendingDirection = "atEnd";
                    }
                    else if (appendingDirection == "atEnd")
                    {
                        appendingDirection = "atStart";
                    }

                    previousInput = currentInput;
                    i--;
                    continue;
                }

                switch (appendingDirection)
                {
                    case "atStart":
                        appendedText = currentInput + appendedText;
                        break;
                    case "atEnd":
                        appendedText = appendedText + currentInput;
                        break;
                }

                previousInput = currentInput;
            }

            Console.WriteLine(appendedText);
        }
    }
}
