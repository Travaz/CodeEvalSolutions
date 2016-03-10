using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _019___ArmstrongNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => double.Parse(line).isArmstrongNumber())
                .ToList()
                .ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }

    internal static class ArmstrongNumber
    {
        public static bool isArmstrongNumber(this double n)
        {
            string nToString = n.ToString();
            List<double> Pow = new List<double>();
            double length = nToString.Length;

            for (int i = 0; i < nToString.Length; i++)
            {
                double number = Char.GetNumericValue(nToString[i]);
                Pow.Add(Math.Pow(number, length));
            }

            if (Pow.Sum() == n)
                return true;
            return false;
        }
    }
}
