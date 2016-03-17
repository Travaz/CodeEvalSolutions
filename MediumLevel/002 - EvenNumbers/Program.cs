using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _002___EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(number => CheckEven(int.Parse(number)))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        static int CheckEven(int n)
        {
            if (n % 2 == 0)
                return 1;
            else
                return 0;
        }
    }
}
