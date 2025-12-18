using System;
class Feet
{
    public static void F()
    {
        double feet,centimeter;
        Console.Write("Enter feet: ");
        feet  = Convert.ToDouble(Console.ReadLine());
        centimeter = feet * 30.48;
        Console.Write(centimeter);
    }
}