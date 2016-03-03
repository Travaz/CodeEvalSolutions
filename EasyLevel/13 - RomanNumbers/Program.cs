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
            using (StreamReader sr = File.OpenText(input))
            {
                while(!sr.EndOfStream)
                {
                    string StringNumber = sr.ReadLine();
                    int Number = int.Parse(StringNumber);
                    Console.WriteLine(ToRomanIntegers(Number));
                }
            }
            Console.ReadLine();
        }

        static string ToRomanIntegers(int number)
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

            while (i -- > 0)
            {
                RomanString += romanNumerals[i][Int32.Parse(intArr[i].ToString())];
            }

            return RomanString;
        }
    }

}
