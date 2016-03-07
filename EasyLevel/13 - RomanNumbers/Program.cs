using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _13___RomanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select((item) => int.Parse(item).ToRomanStrings()).ToList().ForEach(Console.WriteLine);

            Console.ReadLine();
        }
    }

    public static class IntExtensionRoman
    {
        public static string ToRomanStrings(this int number)
        {
            var romanNumerals = new string[][]
            {
                 new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" }, // Primi 10 numeri
                 new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" }, // Decine
                 new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" }, // Centinaia
                 new string[] { "", "M", "MM", "MMM" } // Migliaia
            };

            var RomanString = "";
            var intArr = number.ToString().Reverse().ToArray();
            var i = intArr.Length;

            while (i-- > 0)
            {
                RomanString += romanNumerals[i][Int32.Parse(intArr[i].ToString())];
            }

            return RomanString;
        }
    }

}
