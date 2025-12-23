using System;
class Para
{
    public void Person(string name,int age,string city,char gender = 'F'){
        
        Console.WriteLine($"{name} {age}  {city} {gender}");
    }
}