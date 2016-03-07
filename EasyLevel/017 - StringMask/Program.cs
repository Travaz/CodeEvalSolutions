using System;
using System.Linq;
using System.IO;
using System.Text;

namespace _017___StringMask
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line =>
                {
                    var splitted = line.Split(' ').ToArray();
                    return splitted[0].StringMask(splitted[1]);
                })
                .ToList()
                .ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }

    internal static class Extension
    {
        public static string StringMask(this string stringa, string stringMask)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < stringa.Length; i++)
            {
                string currentDigit = stringa[i].ToString();
                if (stringMask[i] == '1')
                    sb.Append(currentDigit.ToUpper());
                else
                    sb.Append(currentDigit);
            }
            return sb.ToString();
        }
    }
}
