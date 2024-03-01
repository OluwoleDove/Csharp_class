using System;

class VehicleClassification
{
    static void Main()
    {
        Console.WriteLine("Your vehicle type please?");
        string vehicleType = Console.ReadLine();
        
        Console.WriteLine("Your fuel type please?");
        string fuelType = Console.ReadLine();
        
        // Data Casting - Coverts to lower case
        vehicleType = vehicleType.ToLower();
        fuelType = fuelType.ToLower();
        
        //Conditional Statements
        if (vehicleType == "car" || vehicleType == "truck" || vehicleType == "motorcycle"){
            switch (vehicleType){
                case "car":
                    //Fuel type is Electric or Petrol
                    if (fuelType == "petrol" || fuelType == "electric"){
                        Console.WriteLine("This {0} runs on {1}", vehicleType, fuelType); /*Output Formatting*/
                    }
                    else{
                        Console.WriteLine("Fuel type not valid.");
                    }
                break;
                
                case "truck":
                    //Fuel type is Petrol or Diesel
                    if (fuelType == "petrol" || fuelType == "diesel"){
                        Console.WriteLine("This {0} runs on {1}", vehicleType, fuelType);
                    }
                    else{
                        Console.WriteLine("Fuel type not valid.");
                    }
                break;
                
                case "motorcycle":
                    //Fuel tyoe is Petrol
                    if (fuelType == "petrol"){
                        Console.WriteLine("This {0} runs on {1}", vehicleType, fuelType);
                    }
                    else{
                        Console.WriteLine("Fuel type not valid.");
                    }
                break;
            }
        }
        else{
            Console.WriteLine("Invalid Vehicle Type");
        }
    }
}