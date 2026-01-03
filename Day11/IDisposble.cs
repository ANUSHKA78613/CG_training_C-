// using System;
// class ResourceHandler : IDisposable
// {
//  public ResourceHandler()
//     {
//         Console.WriteLine("resource aquired");
//     }   
//     public void Dispose()
//     {
//         Console.WriteLine("resource released");
//     }
// }
class BankAccount
{
    
    private decimal balance;


    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            
        }

        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

   
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal must be positive.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
          
        }

        balance -= amount;
        Console.WriteLine("Withdrawn: " + amount);
    }
}