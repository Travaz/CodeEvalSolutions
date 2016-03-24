using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _031___CleanWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => CleanUpWords(line))
                .ToList()
                .ForEach(Console.WriteLine);
            Console.WriteLine();
            LemmitWay.test(input);
        }

        //Lazy way... Don't know how to cycle until the end of the string
        private static object CleanUpWords(string line)
        {
            StringBuilder sb = new StringBuilder();
            string newline = line.Insert(line.Length, " ");

            for (int i = 1; i <= newline.Length; i++)
            {
                char charachter = newline[i - 1];
                if (char.IsLetter(charachter))
                {
                    sb.Append(charachter);
                    if (!char.IsLetter(newline[i]))
                        sb.Append(" ");
                }                   
            }
            return sb.ToString().ToLower();
        }
    }
}
