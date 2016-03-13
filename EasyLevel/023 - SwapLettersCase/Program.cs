using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023___SwapLettersCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => line.SwapCase())
                .ToList()
                .ForEach(Console.WriteLine);                 
        }

        private static string SwapCase(string[] splitted)
        {
            StringBuilder sr = new StringBuilder();

            foreach (var item in splitted)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    char character = item[i];
                    if (char.IsLetter(character))
                    {
                        if (char.IsLower(character))
                            sr.Append(char.ToUpper(character));
                        else
                            sr.Append(char.ToLower(character));
                    }
                    else
                        sr.Append(character);
                }
                sr.Append(" ");
            }
            return sr.ToString();
        }
    }

    public static class StringExtension
    {
        public static string SwapCase(this string word)
        {
            Func<char, String> selector =
                c => (char.IsLetter(c)
                        ? char.IsUpper(c) ? char.ToLower(c)
                                          : char.ToUpper(c)
                        : c
                     ).ToString();

            return word.Select(selector).Aggregate(String.Concat); 
        }
    }
}
