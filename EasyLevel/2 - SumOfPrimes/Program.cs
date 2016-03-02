using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___SumOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Primes = PrimesLessThanThousend();
            Console.WriteLine(Primes.Sum());
            Console.ReadLine();
        }

        static List<int> PrimesLessThanThousend()
        {
            int divisore;
            bool primo;
            List<int> Primes = new List<int>();

            for (int i = 2; i < 1000; i++)
            {
                primo = true;
                divisore = 2;
                while (divisore <= i/2)
                {
                    if (i % divisore == 0)
                    {
                        primo = false;
                        divisore = i;
                    }
                    divisore++;
                }
                if (primo == true)
                    Primes.Add(i);
            }
            return Primes;
        }
    }
}
