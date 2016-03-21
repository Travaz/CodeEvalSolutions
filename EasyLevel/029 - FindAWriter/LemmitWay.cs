using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _029___FindAWriter
{
    class LemmitWay
    {
        public static string Writer(string[] splitted)
        {
            var letters = splitted[0].ToCharArray();
            var pos = splitted[1]
                        .Substring(1)
                        .Split(' ')
                        .Select(p => int.Parse(p))
                        .ToList();

            return pos.Select(p => letters[p - 1])
                      .Aggregate(
                            string.Empty,
                            (seed, str) => string.IsNullOrEmpty(seed) ? str.ToString() : seed + str
                        );
        }
    }
}
