using System;

class Credit
{
    public static void Run()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- CREDIT OPERATIONS ---");
            Console.WriteLine("1. Net Salary Credit");
            Console.WriteLine("2. Fixed Deposit Maturity");
            Console.WriteLine("3. Credit Card Reward Points");
            Console.WriteLine("4. Employee Bonus Eligibility");
            Console.WriteLine("5. Back");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Net Salary Credit
                    Console.Write("Enter Gross Salary: ");
                    int grossSalary = Convert.ToInt32(Console.ReadLine());
                    int deduction = grossSalary * 10 / 100;
                    int netSalary = grossSalary - deduction;
                    Console.WriteLine("Net salary credited: ₹" + netSalary);
                    break;

                case 2:
                    // Fixed Deposit Maturity
                    Console.Write("Enter Principal: ");
                    int p = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Rate of Interest: ");
                    int r = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Time (years): ");
                    int t = Convert.ToInt32(Console.ReadLine());

                    int interest = (p * r * t) / 100;
                    Console.WriteLine("Fixed Deposit maturity amount: ₹" + (p + interest));
                    break;

                case 3:
                    // Reward Points
                    Console.Write("Enter Credit Card Spending: ");
                    int spending = Convert.ToInt32(Console.ReadLine());

                    int points = spending / 100;
                    Console.WriteLine("Reward points earned: " + points);
                    break;

                case 4:
                    // Bonus Eligibility
                    Console.Write("Enter Annual Salary: ");
                    int salary = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Years of Service: ");
                    int years = Convert.ToInt32(Console.ReadLine());

                    if (salary >= 500000 && years >= 3)
                        Console.WriteLine("Employee is eligible for bonus.");
                    else
                        Console.WriteLine("Employee is not eligible for bonus.");
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
