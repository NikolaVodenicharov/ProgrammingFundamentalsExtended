using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var ban in bannedWords)
            {
                if (text.Contains(ban))
                {
                    text = text.Replace(ban, new string('*', ban.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
