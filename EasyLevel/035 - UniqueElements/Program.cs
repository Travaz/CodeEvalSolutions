using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _035___UniqueElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";

            //First way (OP Linq)
            File.ReadAllLines(input)
                .Select(line => line.Split(',')
                                    .Distinct()
                                    .ToList<String>()
                                    .Aggregate((x, y) => x + "," + y))
                .ToList()
                .ForEach(Console.WriteLine);

            //Second way (OP Extension Method)
            File.ReadAllLines(input)
                .Select(line => line.Split(',').ToList().FilterForDuplicates().Aggregate((x, y) => x + "," + y))
                .ToList()
                .ForEach(Console.WriteLine);
        }


        
    }

    public static class ListExtension
    {
        public static List<T> FilterForDuplicates<T>(this List<T> lista)
        {
            var index = 0;
            while (index < lista.Count - 1)
            {
                if (lista[index].Equals(lista[index + 1]))
                    lista.RemoveAt(index);
                else
                    index++;
            }
            return lista;
        }
    }
}
