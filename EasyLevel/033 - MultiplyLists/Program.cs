using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _033___MultiplyLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => Multiplies(line.Split('|')))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static object Multiplies(string[] arrays)
        {
            StringBuilder sb = new StringBuilder();
            var first = arrays[0].Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToArray();
            var second = arrays[1].Split(' ').Where(x => !string.IsNullOrEmpty(x)).ToArray();

            for (int i = 0; i < first.Length; i++)
            {
                sb.Append(Convert.ToInt16(first[i]) * Convert.ToInt16(second[i]) + " ");
            }

            return sb.ToString();
        }
    }
}
