using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _005___JollyJumpers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => JollyJumpersSequence(line.Split(' ')))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static string JollyJumpersSequence(string[] splitted)
        {
            bool jolly = true;
            var length = splitted.Length - 1;
            List<int> lista = new List<int>(length);

            for (int i = 0; i < length; i++)
            {
                lista.Add(Math.Abs(int.Parse(splitted[i]) - int.Parse(splitted[i+1])));
            }
            lista.Sort();

            for(int i = 1; i < length; i++)
            {
                if (lista[i - 1] != i)
                {
                    jolly = false;
                    break;
                }     
            }

            if (jolly)
                return "Jolly";
            return "Not jolly";
        }
    }
}
