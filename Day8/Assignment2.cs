using System;
 class PatientBill()
{
    public static string BillID ="";
    public static string PatientName ="";
    public static bool hasInsurance;
    public static bool hasLastBill = false;
    public static double ConsultationFee;
    public static double LabCharges;
    public static double MedicineCharges;
    public static double GrossAmount;
    public static double DiscountAmount;
    public static double FinalPayable;
        public static void PatientDetails()
    {
      Console.WriteLine("Enter Bil Id: ");
      BillID = Console.ReadLine();
      Console.WriteLine("Enter Patient Name: ");
      PatientName = Console.ReadLine();
      Console.WriteLine("Is the Patient insured(Y/N): ");
      char value = Convert.ToChar(Console.ReadLine());
      hasInsurance = (value == 'Y')?true:false;
      Console.WriteLine("Enter Consultation Fee: ");
      if(ConsultationFee >= 0)
        {
        ConsultationFee = Convert.ToDouble(Console.ReadLine());  
        }
      Console.WriteLine("Enter Lab Charges: ");
      if(LabCharges >= 0)
        {
        LabCharges = Convert.ToDouble(Console.ReadLine());
        }
      Console.WriteLine("Enter Medicine Charges: ");
      if(MedicineCharges >= 0)
        {
        MedicineCharges = Convert.ToDouble(Console.ReadLine());
        }
     
      Console.WriteLine("\n Bill created successfully.");
      GrossAmount = ConsultationFee+LabCharges+MedicineCharges;
      Console.WriteLine($"Gross Amount: {GrossAmount:F2}");
        if(hasInsurance == true)
        {
            DiscountAmount = GrossAmount*0.10;
        }
        else
        {
            DiscountAmount = 0;
        }
      Console.WriteLine($"Discount Amount: {DiscountAmount:F2}");
      FinalPayable = GrossAmount-DiscountAmount;
      Console.WriteLine($"Final Payable: {FinalPayable:F2}");
    }    
     public static void Show()
    { 
        Console.WriteLine("---------LAST BILL --------------");
        Console.WriteLine($"BillID: {BillID}");
        Console.WriteLine($"Patient: {PatientName}");
        Console.WriteLine($"Insured: {hasInsurance}");
        Console.WriteLine($"Consultation Fee: {ConsultationFee}");
        Console.WriteLine($"Lab Charges: {LabCharges}");
        Console.WriteLine($"Medicine Charges: {MedicineCharges}");
        Console.WriteLine($"Gross Amount: {GrossAmount}");
        Console.WriteLine($"Discount Amount: {DiscountAmount}");
        Console.WriteLine($"Final Payable: {FinalPayable}");
    }
}
