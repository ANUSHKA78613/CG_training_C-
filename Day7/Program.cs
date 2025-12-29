using System;
using System.Collections.Generic;
class Program
{
     public static List<EmployeeRecord> PayrollBoard = new List<EmployeeRecord>();

        public static void Main()
    {
       // Arrays.Index();
       // Dynamic.A();
       // Task.T();
    //    Assign.CleanseAndInvert("Aeroplane");
    // Assign a = new Assign();
    // Console.WriteLine(a.CleanseAndInvert("Aeroplane"));
    // Console.WriteLine(a.CleanseAndInvert("Media"));
    // Console.WriteLine(a.CleanseAndInvert("Cowages"));
    Program obj = new Program();
    int choice;
        do
        {
            Console.WriteLine("1.Register Employee \n 2.Show Overtime Summary\n 3. Calculate Average Monthly Pay\n4. Exit");
            
            Console.WriteLine("Enter Your Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            
          
            switch (choice)
            {
                case 1:
                    obj.RegisterEmployee();
                    break;

                case 2:
                    Console.Write("Enter hours threshold: ");
                    double threshold = Convert.ToDouble(Console.ReadLine());
                    var result = obj.GetOvertimeWeekCounts(PayrollBoard, threshold);

                    if (result.Count == 0)
                        Console.WriteLine("No overtime recorded this month");
                    else
                        foreach (var item in result)
                            Console.WriteLine(item.Key + " - " + item.Value);
                    break;

                case 3:
                    Console.WriteLine("Overall average monthly pay: " +
                        obj.CalculateAverageMonthlyPay());
                    break;

                case 4:
                    Console.WriteLine("Logging off — Payroll processed successfully!");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        } while (choice != 4);
    }

    public void RegisterEmployee()
    {
        Console.Write("Select Employee Type (1-Full time, 2-Contract): ");
        int type = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Hourly Rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        double[] hours = new double[4];
        Console.WriteLine("Enter weekly hours (Week 1 to 4):");
        for (int i = 0; i < 4; i++)
            hours[i] = Convert.ToDouble(Console.ReadLine());

        if (type == 1)
        {
            Console.Write("Enter Monthly Bonus: ");
            double bonus = Convert.ToDouble(Console.ReadLine());

            PayrollBoard.Add(new FullTimeEmployee
            {
                EmployeeName = name,
                HourlyRate = rate,
                MonthlyBonus = bonus,
                WeeklyHours = hours
            });
        }
        else
        {
            PayrollBoard.Add(new ContractEmployee
            {
                EmployeeName = name,
                HourlyRate = rate,
                WeeklyHours = hours
            });
        }

        Console.WriteLine("Employee registered successfully");
    }

    public Dictionary<string, int> GetOvertimeWeekCounts(
        List<EmployeeRecord> records, double hoursThreshold)
    {
        Dictionary<string, int> map = new Dictionary<string, int>();

        foreach (EmployeeRecord emp in records)
        {
            int count = 0;
            foreach (double h in emp.WeeklyHours)
                if (h >= hoursThreshold) count++;

            if (count > 0)
                map.Add(emp.EmployeeName, count);
        }

        return map;
    }

    public double CalculateAverageMonthlyPay()
    {
        if (PayrollBoard.Count == 0) return 0;

        double sum = 0;
        foreach (EmployeeRecord emp in PayrollBoard)
            sum += emp.GetMonthlyPay();

        return sum / PayrollBoard.Count;
    }
}