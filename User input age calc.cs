using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name...");

            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name + " :) ");

            Console.WriteLine("Enter your date of birth... DD/MM/YYYY");

            string input = Console.ReadLine();

            DateTime dateOfBirth;

            if
                (DateTime.TryParse(input, out dateOfBirth))

            {
                int age = CalculateAge(dateOfBirth);

                Console.WriteLine("Your name is " + name + ", you are " + age + " years old.");
            }


            else
            {

                Console.WriteLine("Invalid date format");

            }

            static int CalculateAge(DateTime dateOfBirth)

            {
                                //getting today's date
                DateTime today = DateTime.Today;

                int age = today.Year - dateOfBirth.Year;
                return age;


            }
            Console.ReadKey();
        }
    }
}