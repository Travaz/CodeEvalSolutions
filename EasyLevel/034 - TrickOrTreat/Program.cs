using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _034___TrickOrTreat
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => Equality(line))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static int Equality(string line)
        {
            var elements = line.RemoveWhiteSpaces()
                                .Split(',')
                                .Select(n => int.Parse(n.Split(':')[1]))
                                .ToList();

            var boys = elements[0] + elements[1] + elements[2];
            var candies = elements[0] * 3 + elements[1] * 4 + elements[2] * 5;
            return candies * elements[3] / boys;
        }
    }

    static class StringExtension
    {
        public static string RemoveWhiteSpaces(this string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (!string.IsNullOrWhiteSpace(ch.ToString()))
                    sb.Append(ch);
            }
            return sb.ToString();
        }
    }
}
