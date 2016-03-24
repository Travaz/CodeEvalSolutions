using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _030___MersennePrime
{
    class Program
    {
        static Primes primes = new Primes();
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(n => MersennePrime(double.Parse(n)))
                .ToList()
                .ForEach(Console.WriteLine);

        }

        private static string MersennePrime(double n)
        {
            StringBuilder sb = new StringBuilder();
            double MarsNumber;
            primes.Number = n;
            
            foreach (double number in primes.CalculatePrimes())
            {
                MarsNumber = Math.Pow(2, number) - 1;
                if(MarsNumber < primes.Number)
                    if (primes.isPrime(MarsNumber))
                        sb.Append(MarsNumber + ", ");
            }

            return sb.ToString().TrimEnd(',', ' ');
        }
    }
}
