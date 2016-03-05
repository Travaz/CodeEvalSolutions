using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //FilesOperation.WritingOnFile();
            FilesOperation.ReadingFromFile2();
            Console.ReadLine();
        }

    }

    public static class FilesOperation
    {
        public static void WritingOnFile()
        {
            Random rng = new Random();
            using (TextWriter writer = File.CreateText("input.txt"))
            {
                double dobble = 35.962;
                for (int i = 0; i < 10; i++)
                {
                    dobble += 0.56;
                    writer.WriteLine($"{dobble} {dobble + 0.30} {dobble + 0.45}");
                }
            }
        }

        public static void ReadingFromFile()
        {
            Stopwatch sw = Stopwatch.StartNew();
            using (TextReader reader = File.OpenText("input.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<double> lista = new List<double>();
                    string[] bits = line.Split(' ');
                    foreach (var bit in bits)
                    {
                        double value;
                        if (double.TryParse(bit, NumberStyles.Any, CultureInfo.InvariantCulture, out value))
                            lista.Add(value);
                    }
                    lista.Sort();
                    foreach (var item in lista)
                    {
                        Console.Write($"{item.ToString().Replace(",", ".")} ");
                    }
                    Console.WriteLine();
                }
            }
            sw.Stop();
            Console.WriteLine($"Total time: {sw.ElapsedMilliseconds}ms");
        }

        public static void ReadingFromFile2()
        {
            Stopwatch sw = Stopwatch.StartNew();
            using (StreamReader reader = File.OpenText("input.txt"))
            {
                string format = "F" + 3.ToString();
                IFormatProvider provider = CultureInfo.InvariantCulture;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine()
                        .Split(' ')
                        .Select((number) => double.Parse(number, provider))
                        .ToList();

                    line.Sort();
                    line.ForEach(x => Console.Write($"{x.ToString(format, provider).Replace(",", ".")} "));
                    Console.WriteLine();
                }                        
            }
            sw.Stop();
            Console.WriteLine($"Total time: {sw.ElapsedMilliseconds}ms");
        }
    }
}
