using System;
public interface IArea
{
    public double GetArea();
}
public abstract class Shape : IArea
{
    public abstract double GetArea();
}
public class Circle : Shape
{
    public override double GetArea()
    {
        double r = 9.8;
        return 3.14 * r * r;
    }
}
public class Rectangle : Shape
{
    public override double GetArea()
    {
        double w = 9.7, h = 6.7;
        return w * h;
    }
}
public class Triangle : Shape
{
    public override double GetArea()
    {
        double b = 4.3 , h = 6.7;
        return 0.5 * b * h;
    }
}
public class Program
{
    public static void Main()
    {
    string input = Console.ReadLine();
    Shape s = null;
   
    if(input == "C")
        {
             s = new Circle();
            Console.WriteLine(s.GetArea());
        }
    else if(input == "R")
        {
             s = new Rectangle();
            Console.WriteLine(s.GetArea());
        }
   else if(input == "T")
        {
             s = new Triangle();
            Console.WriteLine(s.GetArea());
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }
}