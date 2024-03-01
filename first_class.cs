using System;

class VehicleClassification
{
    static void Main()
    {
        Console.WriteLine("Enter the type of vehicle (Car, Truck, Motorcycle):");
        string vehicleType = Console.ReadLine();

        Console.WriteLine("Enter the fuel type (Petrol, Diesel, Electric):");
        string fuelType = Console.ReadLine();

        // Casting data
        vehicleType = vehicleType.ToLower(); // Convert to lowercase for case-insensitive comparison
        fuelType = fuelType.ToLower();

        // Check if the entered vehicle type is valid
        if (vehicleType == "car" || vehicleType == "truck" || vehicleType == "motorcycle")
        {
            // Logical operators to handle invalid fuel types
            switch (vehicleType)
            {
                case "car":
                    if (fuelType == "petrol" || fuelType == "electric")
                    {
                        Console.WriteLine("Vehicle classified as a car running on {0} fuel.", fuelType);
                    }
                    else
                    {
                        Console.WriteLine("Invalid fuel type for a car.");
                    }
                    break;

                case "truck":
                    if (fuelType == "petrol" || fuelType == "diesel")
                    {
                        Console.WriteLine("Vehicle classified as a truck running on {0} fuel.", fuelType);
                    }
                    else
                    {
                        Console.WriteLine("Invalid fuel type for a truck.");
                    }
                    break;

                case "motorcycle":
                    if (fuelType == "petrol")
                    {
                        Console.WriteLine("Vehicle classified as a motorcycle running on petrol.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid fuel type for a motorcycle.");
                    }
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid vehicle type.");
        }
    }
}
