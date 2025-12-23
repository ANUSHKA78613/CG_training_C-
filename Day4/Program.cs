 using System;
using System.Security.Authentication.ExtendedProtection;
class Program
{
    static void Main()
    {
    //     BankAccount b = new BankAccount(700,101);
    //   //  BankAccount c = new BankAccount(34,102); 
    //      FixedDeposit fd = new FixedDeposit(3,446,5000);

          // ---------- PART 8: Usage ----------
        // Student s = new Student("REG2025")
        // {
        //     AdmissionYear = 2024   // init-only property
        // };

        // s.StudentID = 101;
        // s.Name = "Anushka";
        // s.Age = 21;
        // s.Marks = 82;
        // s.Password = "secure123";

        // Console.WriteLine("Student ID: " + s.StudentID);
        // Console.WriteLine("Registration No: " + s.RegistrationNumber);
        // Console.WriteLine("Admission Year: " + s.AdmissionYear);
        // Console.WriteLine("Name: " + s.Name);
        // Console.WriteLine("Age: " + s.Age);
        // Console.WriteLine("Marks: " + s.Marks);
        // Console.WriteLine("Result: " + s.Result);
        // Console.WriteLine("Percentage: " + s.Percentage);

       
        // s.RegistrationNumber = "NEWREG";   // private set
        // s.AdmissionYear = 2025;            // init-only
        // Console.WriteLine(s.Password);     // write-only

        // Library l = new Library();
        // l[101] = "C#";
        // l[102] = "c++";
        // l[103] = "Java";
        // Console.WriteLine(l[101]);
        // Console.WriteLine(l[102]);
        // Console.WriteLine(l[103]); // ---- Authentication ----
        Authentication auth = new Authentication();
        auth.Print("anushka", 12345);

        Console.WriteLine();

        // ---- Insurance Policies ----
        InsurancePolicy life = new LifeInsurance
        {
            name = "Anushka",
            PolicyNumber = 101,
            Premium = 2000
        };

        InsurancePolicy health = new HealthInsurance
        {
            Premium = 1500
        };

        Console.WriteLine(life.name);
        Console.WriteLine(life.PolicyNumber);

        Console.WriteLine("Life Premium: " + life.calculate());
        Console.WriteLine("Health Premium: " + health.calculate());

        Console.WriteLine();

        // ---- Method Hiding Demo ----
        LifeInsurance li = new LifeInsurance();
        InsurancePolicy baseRef = li;

        li.Display();        // Child version
        baseRef.Display();  // Base version

        Console.WriteLine();

        // ---- Dictionary + Indexer Demo ----
        Policy p = new Policy();
        p[101] = "Anushka";
        p[102] = "Riya";

        Console.WriteLine("Policy 101 Holder: " + p[101]);
        Console.WriteLine("Policy ID of Anushka: " + p["Anushka"]);
    }
}





