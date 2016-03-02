using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _9___BitPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input).Select(
                line =>
                {
                    var splitted = line.Split(',').Select(n => int.Parse(n)).ToArray();
                    var n1 = (splitted[0] >> (splitted[1] - 1)) & 1;
                    var n2 = (splitted[0] >> (splitted[2] - 1)) & 1;
                    return (n1 ^ n2) == 0;
                })
                .ToList()
                .ForEach(risposta => Console.WriteLine(risposta.ToString().ToLower()));
        }
    }
}
