using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _036___SetIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => IntersectionNumers(line.Split(';')))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static string IntersectionNumers(string[] arrays)
        {
            StringBuilder sb = new StringBuilder();
            List<int> list1 = arrays[0].Split(',').Select(Int32.Parse).ToList();
            List<int> list2 = arrays[1].Split(',').Select(Int32.Parse).ToList();
            var scroll = list1.Count > list2.Count ? list2.Count : list1.Count;

            if(scroll == list1.Count)
            {
                for (int i = 0; i < scroll; i++)
                {
                    int first = list1[i];
                    if (list2.Contains(first))
                        sb.Append(first + ",");
                }
            }
            else
            {
                for (int i = 0; i < scroll; i++)
                {
                    int second = list2[i];
                    if (list1.Contains(second))
                        sb.Append(second + ",");
                }
            }
            return sb.ToString().TrimEnd(',');
        }
    }
}
