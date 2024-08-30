using System;

namespace myApplication
{

    class Program
    {
        static void Main(string[] agrs)
        {

            Console.WriteLine("Enter a sentence!");

            string myString = Console.ReadLine();


            Console.WriteLine("Enter an index to get the character at that position:");

            string index = Console.ReadLine();


            int indexInt = Convert.ToInt32(index);

            var result = myString[indexInt].ToString();

            if (result == null)
            {
                result = "The index is out of range";
            }
            else
            {
                
                Console.WriteLine("The character at position " + index + " is " + result);
            }

            Console.ReadKey();

        }

    }
}