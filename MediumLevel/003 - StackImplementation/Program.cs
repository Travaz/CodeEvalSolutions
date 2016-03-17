using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _003___StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(numbers => AlternateNumbers(numbers.Split(' ')))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static string AlternateNumbers(string[] splitted)
        {
            StringBuilder str = new StringBuilder();
            Stack<int> Numbers = new Stack<int>();

            foreach (var item in splitted)
            {
                Numbers.Push(Int32.Parse(item));
            }

            int elements = Numbers.Count;

            for (int i = 0; i < elements; i++)
            {
                if (i % 2 == 0)
                    str.Append(Numbers.Pop() + " ");
                else
                    Numbers.Pop();
            }

            return str.ToString();
        }
    }
}
