using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _5___MultipliesNumber
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
                    string[] splitted = line.Split(',');

                    int number = int.Parse(splitted[0]);
                    int multiplier = int.Parse(splitted[1]);
                    int multipliering = multiplier;

                    if (multipliering >= number)
                        Console.WriteLine(multipliering);
                    else 
                        while(multipliering <= number)
                        {   
                            multipliering *= 2;
                            if (multipliering >= number)
                                Console.WriteLine(multipliering);                                   
                    }
                }
        }
    }
}
