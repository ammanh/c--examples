using System;
using System.ComponentModel.DataAnnotations;

namespace MyApplication

{
    class Program

    {
        static void Main()

        {

            string[] names = new string[5];

            Console.WriteLine("Please enter 5 names. ");

            for (int i = 0; i < names.Length; i++)

            {
                Console.Write($"Name {i + 1}:");
                names[i] = Console.ReadLine();

            }
            Array.Sort(names);

            Console.WriteLine("Names in alphabetical order: ");

            for (int i = 0; i < names.Length; i++)
            {

                Console.WriteLine($"Name {i + 1}: { names[i]}");

            }

        }

            
    }
}