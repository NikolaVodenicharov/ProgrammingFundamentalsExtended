using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] blacklist = Console.ReadLine().Split(' ');
            List<string> files = new List<string>();

            while (true)
            {
                string file = Console.ReadLine();

                if (file.Equals("end")) { break; }

                bool notRestricted = true;
                foreach (var blacked in blacklist)
                {
                    if (file.Contains(blacked))
                    {
                        notRestricted = false;
                    }
                }

                if (notRestricted)
                {
                    files.Add(file);
                }
            }

            files.Sort();

            Console.WriteLine(String.Join(Environment.NewLine, files));
        }
    }
}
