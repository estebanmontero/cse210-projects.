using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter a number (0 to quit): ");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 0)
                break;

            numbers.Add(userNumber);
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}
