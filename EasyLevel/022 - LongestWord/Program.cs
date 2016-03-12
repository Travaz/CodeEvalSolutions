using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _022___LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => line.Split(' ')
                    .ToList()
                    .MaxStringLength(word => word.Length)                 
                )
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }

    static class MaxStringLengthExtension
    {
        public static string MaxStringLength<T>(this List<T> sequence, Func<T, int> function)
        {
            string maxItem = sequence.First().ToString();
            foreach (var i in sequence)
            {
                string checkingMax = i.ToString();
                if (checkingMax.Length > maxItem.Length)
                    maxItem = checkingMax;
            }

            return maxItem;
        }
    }
}
