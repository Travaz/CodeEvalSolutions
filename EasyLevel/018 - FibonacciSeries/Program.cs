using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _018___FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(number => int.Parse(number).FibonacciNumber())
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }

    internal static class Fibonacci
    {
        public static int FibonacciNumber(this int n)
        {
            if(n == 1)
            {
                return 1;
            }
            else if(n == 0)
            {
                return 0;
            }
            else
            {
                return FibonacciNumber(n - 2) + FibonacciNumber(n - 1);
            }
        }
    }
}
