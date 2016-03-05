using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _016___StringsAndArrows
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line =>
                    line.FindAllIndexesOf(">>-->").Count()
                  + line.FindAllIndexesOf("<--<<").Count()
                  )
                  .ToList()
                  .ForEach(Console.WriteLine);


            Console.ReadLine();           
        }

    }

    public static class IndexExtension
    {
        public static IEnumerable<int> FindAllIndexesOf(this string str, string substring)
        {
            int index = str.IndexOf(substring);
            while(index != -1)
            {
                yield return index;
                str = str.Substring(index + 1);
                index = str.IndexOf(substring);
            }
        }
    }
}
