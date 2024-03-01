/*Develop a C# program for a warehouse management system that categorizes items based on their codes and quantities. Write a program that takes an item code (string) and quantity (integer) as input from the user. The categorization rules are as follows:

If the item code starts with "P" and the quantity is 10 or more, categorize it as "High Priority."
If the item code starts with "M" and the quantity is between 5 and 9 (inclusive), categorize it as "Medium Priority."
If the item code starts with "S" and the quantity is less than 5, categorize it as "Low Priority."
For all other cases, categorize the item as "Normal."
Provide concise sample inputs and outputs similar to the following:

Enter the item code: P123
Enter the quantity: 15
Item is of High Priority.

Enter the item code: M456
Enter the quantity: 8
Item is of Medium Priority.

Enter the item code: S789
Enter the quantity: 3
Item is of Low Priority.

Enter the item code: XYZ
Enter the quantity: 12
Item is Normal Priority.
*/

using System;

class WarehouseManagement
{
    static void Main()
    {
        Console.Write("Enter the item code: ");
        string itemCode = Console.ReadLine();

        Console.Write("Enter the quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int quantity))
        {
            Console.WriteLine("Invalid quantity. Please enter a valid positive integer.");
            return;
        }

        // Categorize the item based on code and quantity
        string category;
        switch (itemCode[0])
        {
            case 'P':
                if (quantity >= 10)
                    category = "High Priority";
                else
                    category = "Normal Priority";
                break;

            case 'M':
                if (quantity >= 5 && quantity <= 9)
                    category = "Medium Priority";
                else
                    category = "Normal Priority";
                break;

            case 'S':
                if (quantity < 5)
                    category = "Low Priority";
                else
                    category = "Normal Priority";
                break;

            default:
                category = "Normal Priority";
                break;
        }

        Console.WriteLine($"Item is {category}.");
    }
}