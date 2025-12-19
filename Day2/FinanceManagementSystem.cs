using System;

class FinanceManagement
{
   public static void solution()
    {
        int choice;

        do
        {
            Console.WriteLine("\nFINANCE MANAGEMENT SYSTEM ");
            Console.WriteLine("1. Debit Operations");
            Console.WriteLine("2. Credit Operations");
            Console.WriteLine("3. Income Tax Calculation");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Debit.Run();     // Debit uses switch-case internally
                    break;

                case 2:
                    Credit.Run();    // Credit uses switch-case internally
                    break;
                case 3:
                Console.WriteLine("Income Tax Calculation");
                double taxRate=0;
                Console.WriteLine("Enter Your Income: ");
                long income =  Convert.ToInt64(Console.ReadLine());
                if(income <= 250000)
                {
                    taxRate = 0;
                }
                else if(income >= 250001 && income <= 500000){
                    taxRate = (income - 250000) * 0.05;
                }
                else if(income >= 500001 && income <= 1000000){
                    taxRate = (250000 * 0.05) + (income - 500000) * 0.20;
                }
                else
                {
                    taxRate = (250000 * 0.05) + (500000 * 0.20) + (income - 1000000) * 0.30;
                }
                 Console.WriteLine($"Tax Payable: ₹ {taxRate}\n");
                    break;
                case 4:
                    Console.WriteLine("Exiting Program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

        } while (choice != 4);
    }
}
