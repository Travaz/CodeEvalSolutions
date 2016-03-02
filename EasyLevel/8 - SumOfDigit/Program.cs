using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _8___SumOfDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            using (StreamReader reader = File.OpenText(input))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    List<int> sum = new List<int>(line.Length);

                    for (int i = 0; i < line.Length; i++)
                        sum.Add((int)Char.GetNumericValue(line[i]));
                    Console.WriteLine(sum.Sum());
                }
            Console.ReadLine();
        }
    }
}
