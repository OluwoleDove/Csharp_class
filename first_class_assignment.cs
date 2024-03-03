using System;

public class Warehouse
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Item code: ");
        string itemCode = Console.ReadLine();
        
        Console.Write("Enter Quantity: ");
        if(!int.TryParse(Console.ReadLine(), out int quantity)){
            Console.WriteLine("Only valid integers are allowed");
            return;
        }
        
        string priority = "";
        switch(itemCode[0]){
            case 'P':
                if(quantity > 10){
                    priority =  "High priority";
                }
                else{
                   priority =  "Normal priority"; 
                }
                break;
            
            case 'M':
                if(quantity >= 5 && quantity <= 9){
                    priority =  "Medium priority";
                }
                else{
                   priority =  "Normal priority"; 
                }
                break;
                
            case 'S':
                if(quantity < 5){
                    priority =  "Low priority";
                }
                else{
                   priority =  "Normal priority"; 
                }
                break;
                
            default:
                priority = "Normal priority";
                break;
        }
        
        Console.WriteLine($"Item is {priority}");
    }
}