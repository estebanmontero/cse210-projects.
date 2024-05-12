using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        Console.WriteLine("Welcome to the Number Guessing Game! I've chosen a number between 1 and 100.");

        while (guess != magicNumber)
        {
            Console.Write("Take a guess: ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Oops, too low.");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Hmm, too high.");
            }
            else
            {
                Console.WriteLine("Congratulations, you guessed it!");
            }

        } 

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
