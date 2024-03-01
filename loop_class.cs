using System;

class NumberAnalysis
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string userName = Console.ReadLine();

        Console.WriteLine($"Hello, {userName}! Enter the count of numbers to analyze:");
        if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
        {
            double[] numbers = new double[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");
                if (double.TryParse(Console.ReadLine(), out double enteredNumber))
                {
                    numbers[i] = enteredNumber;
                }
                else
                {
                    Console.WriteLine("Invalid number. Please enter a valid numeric value.");
                    i--; // Decrement i to re-enter the current index
                }
            }

            double max = numbers[0];
            double min = numbers[0];

            foreach (double num in numbers)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }

            Console.WriteLine($"Hello, {userName}! Analysis results:");
            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine($"Minimum value: {min}");

            switch (ArrayClassification(numbers))
            {
                case "allPositive":
                    Console.WriteLine("Array contains all positive numbers.");
                    break;

                case "allNegative":
                    Console.WriteLine("Array contains all negative numbers.");
                    break;

                case "mix":
                    Console.WriteLine("Array contains a mix of positive and negative numbers.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid count. Please enter a positive integer for the count of numbers.");
        }
    }

    static string ArrayClassification(double[] arr)
    {
        bool hasPositive = false;
        bool hasNegative = false;

        foreach (double num in arr)
        {
            if (num > 0) hasPositive = true;
            else if (num < 0) hasNegative = true;
        }

        return hasPositive && !hasNegative ? "allPositive" :
               !hasPositive && hasNegative ? "allNegative" : "mix";
    }
}
