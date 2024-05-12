using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome usur to my  Grade Calculator!");

        int percent = GetValidGradePercentageFromUser();

        string letter = CalculateLetterGrade(percent);

        DisplayResults(letter, percent);
    }

    static int GetValidGradePercentageFromUser()
    {
        int percent;
        bool isValidInput = false;

        do
        {
            Console.Write("what is your  grade percentage be(0-100): ");
            string input = Console.ReadLine();

            isValidInput = int.TryParse(input, out percent);

            if (!isValidInput || percent < 0 || percent > 100)
            {
                Console.WriteLine("Invalid input! Please enter a number between 0 and 100.");
                isValidInput = false;
            }

        } while (!isValidInput);

        return percent;
    }

    static string CalculateLetterGrade(int percent)
    {
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        return letter;
    }

    static void DisplayResults(string letter, int percent)
    {
        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass this time. Better luck next time!");
        }
    }
}
