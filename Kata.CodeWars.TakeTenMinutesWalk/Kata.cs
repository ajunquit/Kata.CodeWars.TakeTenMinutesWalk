using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.CodeWars.TakeTenMinutesWalk
{
    public class Kata
    {
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Count() != 10)
                return false;

            int n = 0, s = 0, e = 0, w = 0;
            foreach (var block in walk)
            {
                if (block.Equals("n"))
                    n++;

                if (block.Equals("s"))
                    s--;

                if (block.Equals("e"))
                    e++;

                if (block.Equals("w"))
                    w--;
            }
            return (n + s) == 0 && (e + w) == 0;
        }
    }
}
