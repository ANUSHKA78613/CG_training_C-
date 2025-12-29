using System;
using System.IO;
namespace BankingSystem;
public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message):base(message){}
}

public class BankOperationException : Exception
{
   public BankOperationException(string message,Exception innerException):base(message,innerException){} 
}
public class BankAccount
{
    public string AccountNumber{get;private set;}
    public decimal Balance{get;private set;}
  public BankAccount(string accountNumber,decimal initialBalance)
    {
        if (string.IsNullOrWhiteSpace(accountNumber))
        
            throw new ArgumentException("Invalid Account creation is prevented");
        
        AccountNumber = accountNumber;
         if (initialBalance < 0)
        throw new ArgumentException("Initial balance cannot be negative", nameof(initialBalance));

        Balance = initialBalance;
    }

    public void Withdraw(decimal amount)
    {
        try
        {
        if(amount <= 0)
        throw new  ArgumentException("amount cannot be negative");
        if(amount > Balance)
        throw new InsufficientBalanceException("Invalid withdrawal amounts are rejected immediately.");
        Balance -= amount;
        Console.WriteLine("Wuthdrawal successful.Updted balance: " + Balance);
    }
    catch(InsufficientBalanceException ex)
        {
            LogException(ex);
        }
        catch(Exception ex)
        {
            LogException(ex);
            throw new BankOperationException("unexpected error. ",ex);
        }
    }
    private void LogException(Exception ex)
    {
        File.AppendAllText("error1.log",DateTime.Now+"|"+AccountNumber+ex.Message+Environment.NewLine);
    }
}