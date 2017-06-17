using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string biggerValue = GreaterValue(dataType);

            Console.WriteLine(biggerValue);
        }

        static string GreaterValue (string dataType)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            string bigger = string.Empty;

            if (dataType == "int")
            {
                int firstNum = int.Parse(firstInput);
                int secondNum = int.Parse(secondInput);
                bigger = Math.Max(firstNum, secondNum).ToString();
            }
            else if (dataType.Equals("char"))
            {
                char firstChar = Convert.ToChar(firstInput);
                char secondChar = Convert.ToChar(secondInput);
                if (firstChar > secondChar)
                {
                    bigger = firstChar.ToString();
                }
                else
                {
                    bigger = secondChar.ToString();
                }
            }
            else if (dataType == "string")
            {
                if (firstInput.CompareTo(secondInput) > 0)
                {
                    bigger = firstInput;
                }
                else
                {
                    bigger = secondInput;
                }
            }

            return bigger;
        }
    }
}
