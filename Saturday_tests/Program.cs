using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
    //     //Assign.Price();
    //  PatientBill LastBill = new PatientBill();
        
    //     int choice;
    //     do
    //     {
    //         Console.WriteLine("\n========= MediSure Clinic Billing ========");
    //         Console.WriteLine("1. Create New Bill (Enter Patient Details)");
    //         Console.WriteLine("2. View Last Bill");
    //         Console.WriteLine("3. Clear Last Bill");
    //         Console.WriteLine("4. Exit");
    //         Console.WriteLine("Enter your Choice: ");
    //         choice = Convert.ToInt32(Console.ReadLine());
    //         switch (choice)
    //         {
    //             case 1: PatientBill.PatientDetails();
    //                     PatientBill.hasLastBill = true;
    //             break;
    //             case 2: if(PatientBill.hasLastBill == true)
    //                 {
    //                     PatientBill.Show();
    //                 }
    //                 else
    //                 {
    //                     Console.WriteLine("No Bill available. Please create a new bill first");
    //                 }
    //             break;
    //             case 3:
    //                 if(PatientBill.hasLastBill == false){
    //                     Console.WriteLine("No  Bill to be cleared\n");
    //                 }
    //                 else
    //                 {
    //                     PatientBill.hasLastBill = false;
    //                     Console.WriteLine("bill cleared\n");
    //                 }
    //             break;
    //             case 4:Console.WriteLine("Thank You. Application closed normally");
    //             break;
    //             default:Console.WriteLine("Invalid Choice");
    //             break;
    //         }
    //     }
    //     while(choice!=4);
    Assign.Price();
    }
}