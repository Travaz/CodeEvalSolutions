using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _032___AgeDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args.Length > 0 ? args[0] : "input.txt";
            File.ReadAllLines(input)
                .Select(age => CheckAge(int.Parse(age)))
                .ToList()
                .ForEach(Console.WriteLine);
        }

        private static string CheckAge(int age)
        {
            if (age >= 0 && age <= 2)
                return "Still in Mama's arms";
            else if (age >= 3 && age <= 4)
                return "Preschool Maniac";
            else if (age >= 5 && age <= 11)
                return "Elementary school";
            else if (age >= 12 && age <= 14)
                return "Middle school";
            else if (age >= 15 && age <= 18)
                return "High school";
            else if (age >= 19 && age <= 22)
                return "College";
            else if (age >= 23 && age <= 65)
                return "Working for the man";
            else if (age >= 66 && age <= 100)
                return "The Golden Years";
            else
                return "This program is for humans";
        }
    }
}
