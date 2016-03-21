using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _029___FindAWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = (args.Length > 0) ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => Writer(line.Split('|')))
                .ToList()
                .ForEach(Console.WriteLine);
                           
        }

        private static string Writer(string[] splitted)
        {
            StringBuilder sb = new StringBuilder();

            var letters = splitted[0];
            var position = splitted[1]
                                    .Substring(1)
                                    .Split(' ')
                                    .Select(p => int.Parse(p))
                                    .ToList();

            for (int i = 0; i < position.Count; i++)
            {
                int pos = position[i] - 1;
                sb.Append(letters[pos]);
            }

            return sb.ToString();
        }
    }
}
