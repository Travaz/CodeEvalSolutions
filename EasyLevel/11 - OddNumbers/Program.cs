using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oddNumbers = OddNumbers();
            foreach (var item in oddNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static List<int> OddNumbers()
        {
            List<int> oddNumbers = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                if (!(i % 2 == 0))
                    oddNumbers.Add(i);                   
            }
            return oddNumbers;
        }
    }
}
