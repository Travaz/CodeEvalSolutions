using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _014___WordToDigit
{
    class Program
    {
        private static Dictionary<string, int> WordDigit = new Dictionary<string, int>
        { 
            {"zero", 0}, 
            {"one", 1}, 
            {"two", 2}, 
            {"three", 3}, 
            {"four", 4}, 
            {"five", 5}, 
            {"six", 6}, 
            {"seven", 7}, 
            {"eight", 8}, 
            {"nine", 9} 
        }; 

        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => ConverToNumber(line.Split(';')))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static string ConverToNumber(string[] digits)
        {
            var sb = new StringBuilder();
            foreach (var digit in digits)
                sb.Append(WordDigit[digit]);
            return sb.ToString();
        }
    }
}
