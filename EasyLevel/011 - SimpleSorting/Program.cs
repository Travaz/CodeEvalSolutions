using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;
using System.Threading.Tasks;

namespace _011___SimpleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";

            //Lazy Way...
            using (StreamReader reader = File.OpenText(input))
            {
                string format = "F" + 3.ToString();
                IFormatProvider provider = CultureInfo.InvariantCulture;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine()
                        .Split(' ')
                        .Select((number) => double.Parse(number, provider))
                        .ToList();

                    line.Sort();
                    line.ForEach(x => Console.Write($"{x.ToString(format, provider).Replace(",", ".")} "));
                    Console.WriteLine();
                }
            }
            Console.ReadLine();           
        }
    }
}

