using System;
class Patient
{
    public int PatientId { get; }      // read-only
    public string Name { get; set; }
    public int Age { get; set; }

    private string medicalHistory;

    public Patient(int patientId)
    {
        PatientId = patientId;
    }

    public void SetMedicalHistory(string history)
    {
        medicalHistory = history;
    }

    public string GetMedicalHistory()
    {
        return medicalHistory;
    }
}
class Doctor
{
    public static int TotalDoctors;
    public readonly string LicenseNumber;
    public string Name { get; set; }

    static Doctor()
    {
        TotalDoctors = 0;
    }

    public Doctor(string license)
    {
        LicenseNumber = license;
        TotalDoctors++;
    }
}
class Appointment
{
    public void Schedule(Patient p, Doctor d)
    {
        Console.WriteLine($"Appointment Scheduled: {p.Name} with Dr. {d.Name}");
    }

    public void Schedule(Patient p, Doctor d, DateTime date, string mode = "Offline")
    {
        Console.WriteLine($"Appointment Scheduled: {p.Name} with Dr. {d.Name}");
        Console.WriteLine($"Date: {date.ToLongDateString()}, Mode: {mode}");
    }
}
class DiagnosisService
{
    public void Evaluate(
        in int age,
        ref string condition,
        out string riskLevel,
        params int[] testScores)
    {
        int sum = 0;
        foreach (int score in testScores)
            sum += score;

        static bool IsCritical(int total)
        {
            return total > 250;
        }

        if (IsCritical(sum) || age > 60)
        {
            condition = "Serious";
            riskLevel = "High";
        }
        else
        {
            riskLevel = "Moderate";
        }
    }
}
class Billing
{
    public double ConsultationFee { get; set; }
    public double TestCharges { get; set; }
    public double RoomCharges { get; set; }

    public double Total()
    {
        return ConsultationFee + TestCharges + RoomCharges;
    }
}
class InsuranceService
{
    public double ApplyCoverage(double billAmount, int coveragePercent)
    {
        double discount = billAmount * coveragePercent / 100;
        return billAmount - discount;
    }
}
class CalculationHelper
{
    public int CalculateStayDays(int days)
    {
        if (days <= 0)
            return 0;

        return 1 + CalculateStayDays(days - 1);
    }
}
class InputHelper
{
    public int ReadAge(string input)
    {
        if (!int.TryParse(input, out int age))
            throw new Exception("Invalid Input");

        return age;
    }
}
class HospitalSystem
{
    public const string HospitalName = "City Care Hospital";

    static HospitalSystem()
    {
        Console.WriteLine("Hospital System Booting...");
    }
}
