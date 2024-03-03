/*Create a C# program that incorporates various programming concepts. Follow the instructions below:

Your code should:

Request the user's name as input.
Greet the user using their name.
Prompt the user to enter the count of numbers they want to analyze.
Ensure the entered count is a positive integer; display an error message and request re-entry if necessary.
Allow the user to input the specified count of numeric values.
Implement input validation using a while loop, and display an error message if an invalid numeric value is entered.
Find and display the maximum and minimum values from the entered numbers.
Classify the array of numbers into one of three categories:
"allPositive" if all numbers are positive.
"allNegative" if all numbers are negative.
"mix" if there is a mix of positive and negative numbers.
Utilize different looping mechanisms (for loop, while loop, do-while loop) for input and classification validation.
Use break, continue, and return statements appropriately in the code.
Ensure that the program outputs accurate and meaningful results.*/


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
                double enteredNumber; // Declare the variable outside the while loop

                Console.WriteLine($"Enter number {i + 1}:");

                while (!double.TryParse(Console.ReadLine(), out enteredNumber))
                {
                    Console.WriteLine("Invalid number. Please enter a valid numeric value.");
                }

                numbers[i] = enteredNumber;
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

            string classification;
            do
            {
                classification = ArrayClassification(numbers);

                switch (classification)
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

                if (classification == "allPositive" || classification == "allNegative" || classification == "mix")
                    break;

                Console.WriteLine("Invalid classification. Re-evaluating...");
            } while (true);
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

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) hasPositive = true;
            else if (arr[i] < 0) hasNegative = true;
        }

        return hasPositive && !hasNegative ? "allPositive" :
               !hasPositive && hasNegative ? "allNegative" : "mix";
    }
}