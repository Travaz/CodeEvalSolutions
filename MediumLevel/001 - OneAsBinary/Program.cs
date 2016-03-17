using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _001___OneAsBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(num => NumberOfOnes(num))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        public static int NumberOfOnes(string number)
        {
            string n = Convert.ToString(int.Parse(number), 2);
            int count = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == '1')
                    count++;
            }

            return count;
        }
    }
}
