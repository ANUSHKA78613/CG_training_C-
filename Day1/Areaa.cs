using System;

class A
{
    public static void Area()
    {
        Console.Write("Enter radius: ");
        double r = Convert.ToDouble(Console.ReadLine());
        
        double area = Math.PI * r * r;
        Console.WriteLine("Area = " + area);
    }
}
