using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _11___SimpleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            using (StreamReader sr = File.OpenText(input))
            {
                while (!sr.EndOfStream)
                {
                    List<double> sorted = new List<double>();
                    string line = sr.ReadLine();
                    var splitted = line.Split(' ');
                    foreach (var item in splitted)
                    {
                        sorted.Add(double.Parse(item, System.Globalization.NumberStyles.AllowThousands));
                    }
                    sorted.Sort();
                    Console.WriteLine(sorted);
                }               
            }

        }
    }
}

