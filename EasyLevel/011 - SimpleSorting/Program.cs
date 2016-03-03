using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _011___SimpleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            using (StreamReader reader = File.OpenText(input))
            {
                //First try

                while (!reader.EndOfStream)
                {
                    List<double> doubleNumbers = new List<double>();
                    string line = reader.ReadLine();

                    foreach (string DoubleAsString in line.Split(' '))
                        doubleNumbers.Add(Double.Parse(DoubleAsString));

                    doubleNumbers.Sort();
                    foreach (var number in doubleNumbers)
                    {
                        Console.Write($"{number} ");
                    }
                    Console.WriteLine();
                }

                //Second Try

                //while (!reader.EndOfStream)
                //{
                //    List<double> doubles = reader.ReadLine().Split(' ').Select(s => double.Parse(s)).ToList();
                //    foreach (var item in doubles)
                //    {
                //        Console.WriteLine(item);
                //    }
                //}
            }
                         
            Console.ReadLine();
        }
    }
}
