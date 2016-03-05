using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _015___ModOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => ModOperation(line.Split(',')))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static int ModOperation(string[] numbers)
        {
            int n = Int32.Parse(numbers[0]);
            int m = Int32.Parse(numbers[1]);

            if (m > 0)
                return n % m;

            return 0;
        }
    }
}
