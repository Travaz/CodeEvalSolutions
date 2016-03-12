using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _021___SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => SwapElements(line.Split(':')))
                .ToList()
                .ForEach(numbers =>
                {
                    foreach (int number in numbers)
                        Console.Write(number + " ");
                    Console.Write("\n");
                });

        }

        private static int[] SwapElements(string[] splitted)
        {
            var listOfNumbers = splitted[0].Trim().Split(' ').ToArray();
            var swapElements = splitted[1].Trim().Split(',').ToArray();
            int[] SwappedList = new int[listOfNumbers.Length];

            for(int i = 0; i < listOfNumbers.Length; i++)
            {
                var item = listOfNumbers[i];
                    SwappedList[i] = int.Parse(item);
            }

            for (int i = 0; i < swapElements.Length; i++)
            {
                var swapNumbers = swapElements[i].Split('-');
                var a = int.Parse(swapNumbers[0]);
                var b = int.Parse(swapNumbers[1]);
                SwapElementsInList(ref SwappedList[a], ref SwappedList[b]); 
            }

            return SwappedList;
        }

        private static void SwapElementsInList(ref int v1, ref int v2)
        {
            int deposito = v1;
            v1 = v2;
            v2 = deposito;
        }
    }
}
