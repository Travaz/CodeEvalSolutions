using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _4___Reverse_Word
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
                    string[] splitted = line.Split(' ');

                    for (int i = splitted.Length - 1; i >= 0; i--)
                    {
                        Console.Write(splitted[i] + " ");
                    }
                    Console.Write("\n");                  
                }
        }
    }
}
