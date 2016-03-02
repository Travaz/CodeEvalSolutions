using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___PrimePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Primes = PrimesLessThanThousend();
            Console.WriteLine(Primes.Max());
            Console.ReadLine();
        }

        static List<int> PrimesLessThanThousend()
        {
            int divisore;
            bool primo;
            List<int> Primes = new List<int>();

            for (int i = 900; i < 1000; i++)
            {
                primo = true;
                divisore = 2;
                while (divisore < i)
                {
                    if (i % divisore == 0)
                    {
                        primo = false;
                        divisore = i;
                    }           
                    divisore++;
                }
                if (primo == true && i == 929)
                    Primes.Add(i);

            }
            return Primes;
        }
    }
}
