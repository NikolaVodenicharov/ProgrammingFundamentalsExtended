using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputText = Console.ReadLine().Split(' ');
            bool isSymmetry = false;

            int position = 0;
            do
            {
                
                if (inputText[position] == inputText[inputText.Length - 1 - position])
                {
                    isSymmetry = true;
                }
                else
                {
                    isSymmetry = false;
                    break;
                }

                position++;
            } while (position < inputText.Length / 2 - 1);

            Console.WriteLine(isSymmetry ? "Yes" : "No");
        }
    }
}
