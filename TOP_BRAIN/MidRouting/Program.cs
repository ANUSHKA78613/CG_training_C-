using System;
class Program
{
    public static void Main()
    {
        double r = Convert.ToDouble(Console.ReadLine());
        double area = 3.14 * r * r;
        Console.WriteLine($"area = {area:F2}");
    }
}