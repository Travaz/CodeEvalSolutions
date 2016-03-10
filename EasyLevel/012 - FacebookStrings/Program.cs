using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _012___FacebookStrings
{
    class Program
    {
        static IDictionary<char, int> Dict;

        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => BeautifulString(line.Split(' ')))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static int BeautifulString(string[] words)
        {
            int value = 26;
            int sum = 0;
            Dict = new Dictionary<char, int>();

            foreach (string word in words)
            {              
                for (int i = 0; i < word.Length; i++)
                {
                    char letter = char.ToLower(word[i]);
                    if(char.IsLetter(letter))
                    {
                        if (!Dict.ContainsKey(letter))
                            Dict.Add(letter, 1);
                        else
                            Dict[letter]++;
                    }
           
                }               
            }

            foreach (KeyValuePair<char, int> item in Dict.OrderByDescending(key => key.Key))
                sum += (item.Value * value--);
            return sum;
        }
    }
}
