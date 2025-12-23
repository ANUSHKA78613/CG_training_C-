using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
    //     BankAccount b = new BankAccount();

    //     b.Deposit(1000);         
    //    // b.Deposit(500);          

       
// Employee e = new Employee();
// e.name = "fdgdfhd";
// e.salary = 1233.34;
// e.Display();
 
// Wallet w = new Wallet();
// w.AddMoney(1000);
// w.AddMoney(500);
// double balance = w.GetBalance();
// Console.WriteLine("Wallet Balance: " + balance);
// Maths m = new Maths(); // without static

// int a = Maths.Add(22,3); // with static we have to call it using class name
// //int b = Maths.Add(2,3,4);
// double c = m.Add(23.4,45.36);
// Console.WriteLine(a+" "+c);

// Para p = new Para();
// p.Person("Anu",10,"Anushka",'F');  //default parameters always at the last
//     }
// Name.A();

// Console.WriteLine(Paras.Sum(1,3,3));
// Console.WriteLine(Paras.Sum(23,35,454,3));
// Console.WriteLine(Paras.Sum(2,4564,65,4534,53,545,3));
// int x=110;
// Reference.Inc(ref x);
// Console.WriteLine(x);

//   int q, r;   // no initialization required

//         Calculator.Divide(10, 3, out q, out r);

//         Console.WriteLine("Quotient = " + q);
//         Console.WriteLine("Remainder = " + r);
//    int x = 50;
//         Display.Show(in x);

//Calc.Calculate();
//Lam.Example();
// Test.Cacl();
 Console.WriteLine(HospitalSystem.HospitalName);

            InputHelper input = new InputHelper();

            Console.Write("Enter Patient ID: ");
            int pid = int.Parse(Console.ReadLine());

            Console.Write("Enter Patient Name: ");
            string pname = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = input.ReadAge(Console.ReadLine());

            Patient patient = new Patient(pid)
            {
                Name = pname,
                Age = age
            };

            patient.SetMedicalHistory("Diabetes");

            Console.Write("Enter Doctor Name: ");
            string dname = Console.ReadLine();

            Doctor doctor = new Doctor("LIC123")
            {
                Name = dname
            };

            Appointment app = new Appointment();
            app.Schedule(patient, doctor, DateTime.Now);

            DiagnosisService diag = new DiagnosisService();
            string condition = "Normal";
            diag.Evaluate(in age, ref condition, out string risk, 90, 80, 100);

            Billing bill = new Billing
            {
                ConsultationFee = 500,
                TestCharges = 1500,
                RoomCharges = 2000
            };

            InsuranceService insurance = new InsuranceService();
            double finalAmount = insurance.ApplyCoverage(bill.Total(), 20);

            Console.WriteLine("Final Payable Amount: " + finalAmount);
        }
       


    
}

