using System;
using System.Net.Http.Headers;
// using Security.Authentication;
class Program
{
     public Chocolate CalculateDiscountedPrice(Chocolate chocolate)
    {
        
        if(chocolate.Flavour == "Dark")
        {
            chocolate.TotalPrice = chocolate.Quantity*chocolate.PricePerUnit;
            chocolate.DiscountedPrice = chocolate.TotalPrice - (chocolate.TotalPrice*18/100);
        }
        else if(chocolate.Flavour == "Milk")
        {
              chocolate.TotalPrice = chocolate.Quantity*chocolate.PricePerUnit;
            chocolate.DiscountedPrice = chocolate.TotalPrice - (chocolate.TotalPrice*12/100);
        }
        else if(chocolate.Flavour == "White")
        {
             chocolate.TotalPrice = chocolate.Quantity*chocolate.PricePerUnit;
            chocolate.DiscountedPrice = chocolate.TotalPrice - (chocolate.TotalPrice*6/100);
        }
        else
        {
            Console.WriteLine("invalid flavour");
        }
        return chocolate;
    }
    public static void Main()
    {
    Console.WriteLine("enter the f: ");
    string f = Console.ReadLine();
    Console.WriteLine("Enter q: ");
    int q = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter  ppu: ");
    int ppu = int.Parse(Console.ReadLine());
   
Chocolate chocolate = new Chocolate
{
    Flavour = f,Quantity = q, PricePerUnit = ppu
};
if(chocolate.ValidateChocolateFlavour() == false){Console.WriteLine("Invalid flavour");}
        else
        {
             Program p = new Program();
            chocolate = p.CalculateDiscountedPrice(chocolate);
              Console.WriteLine("Flavour : " + chocolate.Flavour);
            Console.WriteLine("Quantity : " + chocolate.Quantity);
            Console.WriteLine("Price Per Unit : " + chocolate.PricePerUnit);
            Console.WriteLine("Total Price : " + chocolate.TotalPrice);
            Console.WriteLine("Discounted Price : " + chocolate.DiscountedPrice);
   }

    }
}