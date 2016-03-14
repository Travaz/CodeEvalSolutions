using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025___MultiplicationTables
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dim = 13;

            for (int i = 1; i < dim; i++)
            {
                for (int j = 1; j < dim; j++)
                {
                    int multiplication = i * j;
                    switch (multiplication.ToString().Length)
                    {
                        case 1:
                            Console.Write($"    {multiplication}");
                            break;
                        case 2:
                            Console.Write($"   {multiplication}");
                            break;
                        case 3:
                            Console.Write($"  {multiplication}");
                            break;                      
                    }                                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
