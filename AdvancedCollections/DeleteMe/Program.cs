using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteMe
{
    class Program
    {
        static void Main(string[] args)
        {
            var mixed = new object[4];
            mixed[0] = 5;
            mixed[1] = 10;
            mixed[2] = null;
            mixed[3] = null;


            var num = Convert.ToInt32(mixed[0]);
            num += 1;
            mixed[0] = num;

            mixed[2] = "George";

            // postName, likes, dislikes, comentatorName, comment
            var letsTry = new Dictionary<string, Dictionary<List<int>, List<string>>>();
        }
    }
}
