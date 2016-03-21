using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _028___MorseCode
{
    class Program
    {
        private static Dictionary<string, string> _MorseCode
            = new Dictionary<string, string>()
            {
                {".-", "A"},
                {"-...", "B"},
                {"-.-.", "C"},
                {"-..", "D"},
                {".", "E"},
                {"..-.", "F"},
                {"--.", "G"},
                {"....", "H"},
                {"..", "I"},
                {".---", "J"},
                {"-.-", "K"},
                {".-..", "L"},
                {"--", "M"},
                { "-.", "N"},
                {"---", "O"},
                {".--.", "P"},
                { "--.-", "Q"},
                {".-.", "R"},
                {"...", "S"},
                {"-", "T"},
                {"..-", "U"},
                {"...-", "V"},
                {".--", "W"},
                {"-..-", "X"},
                {"-.--", "Y"},
                {"--..", "Z"},

                {".----", "1" },
                {"..---", "2" },
                {"...--", "3" },
                {"....-", "4" },
                {".....", "5" },
                {"-....", "6" },
                {"--...", "7" },
                {"---..", "8" },
                {"----.", "9" },
                {"-----", "0" },

                {"", " "},
            };

        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line =>
                    line.Split(' ')
                        .Select(_MC => _MorseCode[_MC])
                        .Aggregate(
                            string.Empty,
                            (seed, str) => string.IsNullOrEmpty(seed) ? str : seed + str
                        )
                    )
                    .ToList()
                    .ForEach(Console.WriteLine);
        }
    }
}
