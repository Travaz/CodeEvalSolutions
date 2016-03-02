using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            FileInfo f = new FileInfo(input);
            Console.WriteLine(f.Length);
            Console.ReadLine();
        }
    }
}
