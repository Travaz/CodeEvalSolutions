using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030___MersennePrime
{
    class Primes
    {
        public double Number { get; set; }

        public IEnumerable<double> CalculatePrimes()
        {
            for (double i = 2; i < Number; i++)
            {
                if (isPrime(i))
                    yield return i;
            }
        }

        public bool isPrime(double i)
        {
            for (double j = 2; j < Math.Sqrt(i); j++)
                if (i % j == 0)
                    return false;
                return true;
        }
    }
}
