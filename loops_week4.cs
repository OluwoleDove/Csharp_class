using System;

class NumberAnalysis
{
    static void Main()
    {
        string classifyNum;
        bool hasPositive = false;
        bool hasNegative = false;
        
        Console.WriteLine("Enter your name: ");
        string userName = Console.ReadLine();
        
        Console.WriteLine($"Hello {userName}! Enter the count of numbers to analyze: ");
        if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
        {
            double[] numbers = new double[count];
            
            //FOR LOOP
            for (int i = 0; i < count; i++){
                double enteredNumber;
                Console.WriteLine($"Enter number {i + 1}: ");
                //WHILE LOOP
                while (!double.TryParse(Console.ReadLine(), out enteredNumber)){
                    Console.WriteLine("Invalid number, please enter an actual integer number: ");
                }
                numbers [i] = enteredNumber;
                if (enteredNumber > 0) hasPositive = true;
                if (enteredNumber < 0) hasNegative = true;
            }
            
            double max = numbers[0];  
            double min = numbers[0];  
            //FOREACH LOOP
            foreach (double num in numbers){
                if (num > max) {
                    max = num;
                }
                if (num < min) min = num;
            }
            Console.WriteLine($"Hello {userName}, Analysis Results:");
            Console.WriteLine("Maximum number is {0}.", max);
            Console.WriteLine("Minimum number is {0}.", min);
            
            //DO WHILE LOOP
            classifyNum = hasPositive && !hasNegative ? "allPositive": !hasPositive && hasNegative ? "allNegative" : "mix";
            
            switch (classifyNum) {
                case "allPositive":
                    Console.WriteLine("Entered Numbers are all positive.");
                    break;
                    
                case "allNegative":
                    Console.WriteLine("Entered Numbers are all negative.");
                    break;
                        
                case "mix":
                    Console.WriteLine("Entered Numbers are a mix of positive and negative values.");
                    break;
            }
        }
    }
}