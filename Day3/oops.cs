using System;

class BankAccount
{
    private double balance;   

    public void Deposit(double amount)
    {
        balance = balance + amount;
        Console.WriteLine(balance);
    }

}