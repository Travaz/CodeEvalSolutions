using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _021___SwapElements
{
    class LemmitWay
    {
        public static void test(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => SwapElements(line.Split(':')))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static string SwapElements(string[] splitted)
        {
            var array = splitted[0].Trim().Split(' ').ToArray();
            splitted[1].Trim().Split(',').ToList().ForEach(func =>
            {
                int from = int.Parse(func.Split('-')[0].Trim());
                int to = int.Parse(func.Split('-')[1].Trim());
                Swap(ref array[from], ref array[to]);
            });

            return array.Aggregate(
                string.Empty,
                (seed, str) =>
                    string.IsNullOrEmpty(seed) ? str : seed + " " + str
                    );
        }

        private static void Swap(ref string v1, ref string v2)
        {
            var deposito = v1;
            v1 = v2;
            v2 = deposito;
        }
    }
}
