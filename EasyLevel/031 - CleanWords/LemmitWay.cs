using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _031___CleanWords
{
    public class LemmitWay
    {
        public static void test(string path)
        {
            File.ReadAllLines(path)
                .Select(line =>
                            line
                                .SplitUsingNonLetters()
                                .Select(word => word.ToLower())
                                .Aggregate(string.Empty, (seed, str) => string.IsNullOrEmpty(seed) ? str : seed + " " + str)
                        )
                        .ToList()
                        .ForEach(Console.WriteLine);
        }
    }

    public static class SplittedExt
    {
        public static IEnumerable<string> SplitUsingNonLetters(this string str)
        {
            var offset = 0;
            while (offset < str.Length)
            {
                while (offset < str.Length && !char.IsLetter(str[offset]))
                {
                    offset++;
                }

                var sb = new StringBuilder();

                while (offset < str.Length && char.IsLetter(str[offset]))
                {
                    sb.Append(str[offset]);
                    offset++;
                }
                yield return sb.ToString();
            }
        }
    }
}
