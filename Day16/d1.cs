using System.Reflection;
using System;
class Employee
{
    public int Id{get;set;}
    public string Name{get;set;}
    public string n = "Anu";
    public Employee()
    {
        
    }
    public Employee(int id,string name)
    {
     Id = id;
     Name = name;   
    }
    public void Display()
    {
        Console.WriteLine("Student Display Method");
    }
}