using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _004___LastFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(line => ElementsAtIndex(line.Split(' ').ToStack()))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static char ElementsAtIndex(Stack<string> splitted)
        {
            int pos = Int32.Parse(splitted.Pop());
            int length = splitted.Count;

            if(pos <= length)
            {
                for (int i = 0; i < pos - 1; i++)
                {
                    splitted.Pop();
                }
            }
            else
                return ' ';

            char element = char.Parse(splitted.Pop());
            return element;
        }

        private static char ElementsAtIndexWithoutStack(string[] splitted)
        {
            Stack<string> Stacking = new Stack<string>(splitted);
            int pos = Int32.Parse(Stacking.Pop());
            int length = Stacking.Count;

            if (pos <= length)
            {
                for (int i = 0; i < pos - 1; i++)
                {
                    Stacking.Pop();
                }
            }
            else
                return ' ';

            char element = char.Parse(Stacking.Pop());
            return element;
        }
    }

    /// <summary>
    /// Implementation of the stack extension class
    /// </summary>
    public static class StackExtension
    {
        /// <summary>
        /// Allowed as to print the elements of a collection into a stack implementation
        /// </summary>
        /// <typeparam name="T">Generic that retrieve the type of the elements that call this method</typeparam>
        /// <param name="elements">Collection that calls this method</param>
        /// <returns></returns>
        public static Stack<T> ToStack<T>(this IEnumerable<T> elements)
        {
            Stack<T> StackImplementation = new Stack<T>();
            foreach (var item in elements)
            {
                StackImplementation.Push(item);
            }

            return StackImplementation;
        }
    }
}
