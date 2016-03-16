using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _027___PercentageCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => RatioCase(line))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static string RatioCase(string line)
        {
            double countUpper = 0;
            double countLower = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char character = line[i];
                if (char.IsLetter(character))
                {
                    if (char.IsUpper(character))
                        countUpper++;
                    else
                        countLower++;
                } 
            }

            string ratioLower = (countLower / line.Length).ToString("0.00%").Replace('%', ' ').Replace(',', '.');
            string ratioUpper = (countUpper / line.Length).ToString("0.00%").Replace('%', ' ').Replace(',', '.');

            return "lowercase: " + ratioLower + "uppercase: " + ratioUpper;
        }
    }
}
