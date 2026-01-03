using System;
using System.Linq;
class Program
{
    public static void Main()
    {
        // Console.WriteLine("Creating Objects");
        // for(int i = 0; i < 5; i++)
        // {
        //     My_Class obj =  new My_Class();
        // }
        // Console.WriteLine("forcing garbage collection");
        //  GC.Collect();
        // // Console.WriteLine("hello");
        // GC.WaitForPendingFinalizers();
        // Console.WriteLine("Garbage Collection Collected");

        // TUPLE
        // var student = (ID:101,Name:"Amit");
        //  (int,string) s1 = (1011,"Amitt");
        // Console.WriteLine(student.GetType());
        // Console.WriteLine(s1.GetType());
        // //Anonymous
        // var an = new {ID=101,Name="Anu"};
        // Console.WriteLine(an.GetType());

        // multiple return types
        // static(int sum,int average ,int diff) Calculate(int a,int b)
        // {
        //     return (a+b, (a+b)/2,a-b);
        // }
        // Console.WriteLine(Calculate(2,3));
        // static(bool isValid,string messag) ValidateUser(string username)
        // {
        //     if(string.IsNullOrEmpty(username))
        //     return (false,"username required");
        //     return (true,"Valid user");
        // }
        // var response = ValidateUser("Admin");
        // Console.WriteLine(response.message);
        // var person = (ID:1,Name:"Anu");
        // Console.WriteLine(person.ID);
        // var(id,name) = person; // decontruction of tuple
        // Console.WriteLine(id);
        // Console.WriteLine(person.GetType());
        // var(_,name) = person; // discard of id
        
            // var s = new Student { Id = 1, Name = "Amit" }; // s is object of student class
            // Console.WriteLine(s.GetType());
            // var (sid, sname) = s;

            // Console.WriteLine(sid);
            // Console.WriteLine(sname);



int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
var ascending = numbers.OrderBy(n => n);
var descending = numbers.OrderByDescending(m => m);
foreach(var i in ascending)
        {
            Console.Write(i);
        }
        Console.WriteLine();
foreach(var i in descending)
        {
            Console.Write(i);
        }
// var evenNumbers = numbers. Where(n => n % 2 == 0); // LINQ
// Console.WriteLine(evenNumbers.GetType());
// Console.WriteLine("Even numbers are:");
// foreach (var n in evenNumbers)
//         {
//             Console.WriteLine(n);
//         }

// var a = numbers.Where(n=>n>3).Select(n=>n*2);
//  foreach (var n in a)
//         {
//             Console.WriteLine(n);
        
//         }
        // List<Student> students = new List<Student>
        // {
        //     new Student("Anushka", 233),
        //     new Student("Amit", 45)
        // };

        // var result = students.Select(s => new
        // {
        //     s.Name,
        //     Grade = s.Marks > 60 ? "Pass" : "Fail"
        // });

        // Console.WriteLine(result.ToList().GetType());
        
// List<Employee> employees = new List<Employee>
// {
// new Employee { Name = "Amit", Salary = 50000 },
// new Employee { Name = "Ravi", Salary = 70000 },
//  new Employee { Name = "Neha", Salary = 60000 }
// };
// var sortedBySalary = employees.OrderBy(e => e. Salary);
// foreach(var i  in sortedBySalary)
//         {
//             Console.WriteLine(i.Salary);
//         }
//------------------------------------------------
// IDISSPOSABLE.CS
//using(ResourceHandler rh = new ResourceHandler());


// rh.Dispose();
    Console.WriteLine($"Total Memory Before GC: {GC.GetTotalMemory(false)} bytes");

        for (int i = 0; i < 10000; i++)
        {
            object obj = new object(); // Gen 0 allocation
        }

        Console.WriteLine($"Total Memory After Object Creation: {GC.GetTotalMemory(false)} bytes");

        GC.Collect(); 
        GC.WaitForPendingFinalizers();

        Console.WriteLine($"Total Memory After GC: {GC.GetTotalMemory(false)} bytes");
        Console.WriteLine($"Generation of a new object: {GC.GetGeneration(new object())}");
    }
}






// class Student
// {
//     // public int age { get; set; }
//     // public string Name { get; set; }

//     // public void Deconstruct(out int id, out string name)
//     // {
//     //     id = Id;
//     //     name = Name;
//     // }

//    public string Name;
//     public int Marks;

//     public Student(string name, int marks)
//     {
//         Name = name;
//         Marks = marks;
//     }
// }

// class Employee
// {
// public string Name { get; set; }
// public int Salary { get; set; }
// }


class Student
{
    
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("name:"+ Name);
        Console.WriteLine(" Age: " + Age);
    }
}