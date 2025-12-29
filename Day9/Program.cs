using System;
using System;
using System.IO;
using BankingSystem;
class Program
{
  
    public static void Main()
    {
        //  Ex.Hand();
    //     try
    //     {
    //         Console.Write("Enter withdrawal amount: ");
    //         decimal amount = decimal.Parse(Console.ReadLine());
    //         int serviceCharge = 100;
    //         int divisionCheck = serviceCharge/int.Parse("0");
    //         BankAccount account = new BankAccount();
    //         account.Withdraw(amount);
    //         Console.WriteLine("Withdrawal successfull");
    //     }
    //     catch(FormatException ex)
    //     {
    //         LogException(ex);
    //         Console.WriteLine("invalid input format");
    //     }
    //     catch(DivideByZeroException ex)
    //     {
    //         LogException(ex);
    //         Console.WriteLine("Arithmetic error occured");
    //     }
    //     catch(InsufficientBalanceException ex)
    //     {
    //         LogException(ex);
    //         Console.WriteLine("an excepted error occured");
    //      }
    //     finally
    //     {
    //         Console.WriteLine("Transaction attempt completed");
    //     }
         
    //     }
    //     static void LogException(Exception ex)
    // {
    //     File.AppendAllText("error.log",DateTime.Now + "|" + ex.GetType().Name+"|"+ex.Message+ Environment.NewLine);
//     FileStream file = null;
// try
// {
//     file = new FileStream("data.txt", FileMode.Open);
//     // Perform file operations
//     int data = file.ReadByte();
//     Console.WriteLine(data);
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine("File not found: " + ex.Message);
// }
// finally
// {
//     if (file != null)
//     {
//         file.Close(); // Ensures file is always closed
//         Console.WriteLine("File stream closed in finally block.");
//     }
// }


// try
// {
//     try
//     {
//         int data = int.Parse(File.ReadAllText("transactions.txt"));
//         Console.WriteLine(data);
//     }
//     catch (IOException ioEx)
//     {
//         throw new ApplicationException(
//             "Unable to load transaction data",
//             ioEx
//         );
//     }
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Message: " + ex.Message);
//     Console.WriteLine("Root Cause: " + ex.InnerException.Message);
// }
     
        
            // Create account with initial balance
             BankAccount account = new BankAccount("AC3975",878);
             account.Withdraw(5666);
            
        
    }
}