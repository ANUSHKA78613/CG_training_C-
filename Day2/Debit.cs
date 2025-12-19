using System;

class Debit
{
    public static void Run()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- DEBIT OPERATIONS ---");
            Console.WriteLine("1. ATM Withdrawal Limit Validation");
            Console.WriteLine("2. Loan Eligibility & EMI Burden Check");
            Console.WriteLine("3. Daily Debit Transaction Calculator");
            Console.WriteLine("4. Minimum Balance Compliance Check");
            Console.WriteLine("5. Back");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // ATM Withdrawal Limit
                    Console.Write("Enter withdrawal amount: ");
                    int amount = Convert.ToInt32(Console.ReadLine());

                    if (amount <= 40000)
                        Console.WriteLine("Withdrawal permitted within daily limit.");
                    else
                        Console.WriteLine("Daily ATM withdrawal limit exceeded.");
                    break;

                case 2:
                    // Loan Eligibility + EMI Burden (previous code included)
                    Console.Write("Enter Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Monthly Income: ");
                    int income = Convert.ToInt32(Console.ReadLine());

                    if (age < 21 || income < 30000)
                    {
                        Console.WriteLine("Not eligible for loan.");
                        break;
                    }

                    Console.Write("Enter EMI Amount: ");
                    int emi = Convert.ToInt32(Console.ReadLine());

                    if (emi <= income * 0.4)
                        Console.WriteLine("Loan eligible and EMI is financially manageable.");
                    else
                        Console.WriteLine("Loan eligible but EMI exceeds safe income limit.");
                    break;

                case 3:
                    // Daily Debit Transactions (loop + continue reused)
                    Console.Write("Enter number of transactions: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    int total = 0;

                    for (int i = 1; i <= n; i++)
                    {
                        Console.Write("Enter transaction amount " + i + ": ");
                        int amt = Convert.ToInt32(Console.ReadLine());

                        if (amt < 0)
                        {
                            Console.WriteLine("Invalid transaction skipped.");
                            continue;
                        }

                        total += amt;
                    }

                    Console.WriteLine("Total debit amount for the day: ₹" + total);
                    break;

                case 4:
                    // Minimum Balance Check
                    Console.Write("Enter current balance: ");
                    int balance = Convert.ToInt32(Console.ReadLine());

                    if (balance < 2000)
                        Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
                    else
                        Console.WriteLine("Minimum balance requirement satisfied.");
                    break;

                case 5:
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 5);
    }
}
