/*
Create a C# program that simulates a basic inventory management system. Follow the instructions below:

Instructions:

Request the user to input the total number of items in the inventory.
Validate the entered value to ensure it is a positive integer; display an error message and request re-entry if necessary.
Utilize a for loop to allow the user to input details for each item in the inventory, including name and quantity.
Implement input validation within the for loop using a while loop; ensure that the quantity entered is a non-negative integer.
Display a summary of the inventory, listing the names and quantities of each item.
Allow the user to search for a specific item in the inventory by entering its name.
Utilize a do-while loop for the search functionality; continue the loop until the user decides to exit the search.
If the item is found, display its details; if not found, inform the user.
Use break, continue, and return statements appropriately in the code.
Ensure that the program provides accurate and meaningful results.
 */


using System;

class InventoryManagement
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Inventory Management System!");

        Console.WriteLine("Enter the total number of items in the inventory:");
        if (int.TryParse(Console.ReadLine(), out int itemCount) && itemCount > 0)
        {
            string[] itemNames = new string[itemCount];
            int[] itemQuantities = new int[itemCount];

            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine($"Enter details for item {i + 1}:");
                Console.Write("Item Name: ");
                itemNames[i] = Console.ReadLine();

                // Input validation for quantity using while loop
                while (true)
                {
                    Console.Write("Quantity: ");
                    if (int.TryParse(Console.ReadLine(), out int quantity) && quantity >= 0)
                    {
                        itemQuantities[i] = quantity;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid quantity. Please enter a non-negative integer.");
                    }
                }
            }

            Console.WriteLine("\nInventory Summary:");
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine($"{itemNames[i]} - Quantity: {itemQuantities[i]}");
            }

            do
            {
                Console.WriteLine("\nEnter the name of the item to search (or 'exit' to end search):");
                string searchItem = Console.ReadLine();

                if (searchItem.ToLower() == "exit")
                {
                    break;
                }

                bool itemFound = false;
                for (int i = 0; i < itemCount; i++)
                {
                    if (itemNames[i].Equals(searchItem, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"{searchItem} found in the inventory. Quantity: {itemQuantities[i]}");
                        itemFound = true;
                        break;
                    }
                }

                if (!itemFound)
                {
                    Console.WriteLine($"{searchItem} not found in the inventory.");
                }

                Console.WriteLine("Do you want to search for another item? (yes/no)");
            } while (Console.ReadLine().ToLower() == "yes");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for the total number of items.");
        }
    }
}
