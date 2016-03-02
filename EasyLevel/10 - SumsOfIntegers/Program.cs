using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _10___SumsOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            Console.WriteLine(File.ReadAllLines(input)
                .Select(line =>
                {
                    return int.Parse(line);
                })
                .ToList().Sum());               
        }
    }
}

