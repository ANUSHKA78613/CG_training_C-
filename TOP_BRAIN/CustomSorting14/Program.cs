using System;
using System.Collections.Generic;
public class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}
class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Anu", Age = 22, Marks = 90 },
            new Student { Name = "Ravi", Age = 20, Marks = 95 },
            new Student { Name = "Neha", Age = 19, Marks = 90 }
        };
        students.Sort((x, y) =>
        {
            int markCompare = y.Marks.CompareTo(x.Marks); 
            if (markCompare != 0)
                return markCompare;
            return x.Age.CompareTo(y.Age);
        });
        //  var sortedStudents = students.OrderByDescending(s => s.Marks).ThenBy(s => s.Age).ToList();
        // foreach (var s in sortedStudents)
        // {
        //     Console.WriteLine($"{s.Name} - Age: {s.Age}, Marks: {s.Marks}");

        foreach (var s in students)
        {
            Console.WriteLine($"{s.Name} - Age = {s.Age} - Marks = {s.Marks}");
        }
    }
}