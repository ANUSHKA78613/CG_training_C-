using System;
class Finance
{
    public static void check()
    {
        int Choice;
        do{
        Console.Write("\nPlease Enter Your Choice:\n 1 Credit \n 2 for Income Tax Calculation \n 3 Debit \n 4 for Exit:\n ");
        Choice = Convert.ToInt32(Console.ReadLine());
        
        switch (Choice)
        {
        case 1: Console.WriteLine("Loan Eligibility Check");
                Console.Write("Enter Age: ");
                int age =  Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter income: ");
                long inc =  Convert.ToInt64(Console.ReadLine());
                if(age >= 21 && inc >= 30000)
                {
                    Console.Write("Eligible for Loan");
                }
                else
                {
                      Console.Write("Not Eligible for Loan\n");
                }
                    break;
        case 2: Console.WriteLine("Income Tax Calculation");
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

        case 3: Console.WriteLine("Transaction Entry System");
                Console.WriteLine("Enter 5 transactions:");

             for (int i = 1; i <= 5; i++)
              {
            Console.Write("Transaction " + i + ": ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount < 0)
            {
                Console.WriteLine("Invalid transaction! Skipped\n");
                continue;
            }

            Console.WriteLine($"Transaction accepted: ₹{amount}\n");
        }
        break;
    
        case 4: Console.WriteLine("Exit Program");
                    break;
                    
        default: Console.WriteLine("Invalid Choice");
                    break;
        }
    
    }
     while(Choice != 4);
}
}