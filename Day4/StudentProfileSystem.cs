using System;

class Student
{
    // ---------- PART A: Auto-Implemented Property ----------
    public int StudentID { get; set; }

    // ---------- PART 5: Property with Private Set ----------
    public string RegistrationNumber { get; private set; }

    // ---------- PART 6: Init-Only Property ----------
    public int AdmissionYear { get; init; }

    // ---------- PART D: Normal Properties with Validation ----------
    private string name;
    private int age;
    private int marks;

    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                name = value;
            else
                Console.WriteLine("Name cannot be empty");
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
                age = value;
            else
                Console.WriteLine("Age must be greater than 0");
        }
    }

    public int Marks
    {
        get { return marks; }
        set
        {
            if (value >= 0 && value <= 100)
                marks = value;
            else
                Console.WriteLine("Marks must be between 0 and 100");
        }
    }

    // ---------- PART B: Read-Only Property ----------
    public string Result
    {
        get
        {
            return marks >= 40 ? "Pass" : "Fail";
        }
    }

    // ---------- PART 7: Expression-Bodied Property ----------
    public double Percentage => (marks / 100.0) * 100;

    // ---------- PART C: Write-Only Property ----------
    private string password;
    public string Password
    {
        set
        {
            if (value.Length >= 6)
                password = value;
            else
                Console.WriteLine("Password must be at least 6 characters long");
        }
    }

    // ---------- Constructor ----------
    public Student(string regNo)
    {
        RegistrationNumber = regNo;   // private set allowed inside class
    }
}
