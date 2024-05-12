using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");

        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();

        int userNumber;
        if (int.TryParse(userInput, out userNumber))
        {
            int squaredNumber = SquareNumber(userNumber);
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number next time.");
        }
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }
}
