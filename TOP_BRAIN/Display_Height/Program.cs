using System;
class Program
{
    public static void Main()
    {
        int height = Convert.ToInt32(Console.ReadLine());
        if(height < 150)
        {
            Console.WriteLine("Short");
        }
        else if(height >= 150 && height < 180)
        {
            Console.WriteLine("Average");
        }
        else
        {
            Console.WriteLine("Tall");
        }
    }
}