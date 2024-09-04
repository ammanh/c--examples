using System;

namespace myApplication

{
    class Program
    {
        static void Main(string[] args)

        {
            string playAgain;

            do
            {
                Random Random = new Random();
                int targetNumber = Random.Next(1, 101);
                int guess;

                Console.WriteLine("Guess the number i am thinking of between 1 and 101!");

                do
                {
                    Console.WriteLine("Enter your guess ");

                    guess = int.Parse(Console.ReadLine());

                    if (guess < targetNumber)
                        Console.WriteLine("Too low. Try again. ");

                    else if (guess > targetNumber)
                        Console.WriteLine("Too high. Try again. ");
                } while (guess != targetNumber);

                Console.WriteLine("You guessed the number!");

                Console.WriteLine("Play Again? (yes/no");
                playAgain = Console.ReadLine().ToLower();

            } while (playAgain == "yes");
        }
    }
}






