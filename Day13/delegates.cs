using System;
 delegate void PaymentDelegate(decimal amount);
class PaymentServices
{
   
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("process payment: "+ amount);
    }
    public void Rtgs(decimal amt)
    {
        Console.WriteLine("rtgs payment: "+ amt);
    }
// }
// static class PaymentExtensions
// {
//     public static bool IsValidPayment(this decimal amount)
//     {
//         return amount > 0 && amount <= 10_00_000;
//     } 
}