using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace LowerCase
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
                    Console.WriteLine(sr.ReadLine().ToLower());
                }
            }
            Console.ReadLine();
        }
    }
}
