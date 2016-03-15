using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026___RightMostChar
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => RightMostChar(line.Split(',')))
                .ToList()
                .ForEach(Console.WriteLine);

            Console.ReadLine();               
        }

        private static int RightMostChar(string[] splitted)
        {
            int pos = -1;
            string phrase = splitted[0];
            char character = char.Parse(splitted[1]);

            for (int i = phrase.Length - 1; i >= 0; i--)
            {
                if(phrase[i] == character)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
    }
}
