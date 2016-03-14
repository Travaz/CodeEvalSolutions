using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _024___PenultimateWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => GetPenultimateString(line.Split(' ')))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static string GetPenultimateString(string[] v)
        {
            return v[v.Length - 2];
        }
    }
}
