using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _020___CapitalizeWords
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
                    var splitted = line.Split(' ');

                    for (int i = 0; i < splitted.Length; i++)
                    {
                        string word = splitted[i];
                        string sub = word.Substring(1);
                        Console.Write(char.ToUpper(word[0]) + sub + " ");
                    }
                    Console.Write("\n");
                }
            Console.ReadLine();
        }
    }
}
