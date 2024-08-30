//namespace myApplication

//{


//    class Program
//    {
//        static void Main(string[] args)
//        {
//            {
//                string isRaining = "yes";
//                string haveUmbrella = "no";

//                if (isRaining == "yes")
//                {
//                    Console.WriteLine("It's raining outside");

//                    if (haveUmbrella == "yes")
//                    {
//                        Console.WriteLine("You have an umbrella");
//                    }
//                    else
//                    {
//                        Console.WriteLine("You don't have an umbrella");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("It's not raining outside");
//                }
//            }
//        }
//    }
//}





using System;

namespace myApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is it raining? (yes/no)");
            string isRaining = Console.ReadLine().ToLower();

            if (isRaining == "yes")
            {
                Console.WriteLine("It's raining outside");
            }
            else if (isRaining == "no")
            {
                Console.WriteLine("It's not raining outside");
            }
            else
            {
                Console.WriteLine("Invalid input. Enter 'yes' or 'no'.");
            }
        }
    }
}

