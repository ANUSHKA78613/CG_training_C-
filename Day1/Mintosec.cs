using System;

class Min
{
    public static void C()
    {
        int min, sec;

        Console.Write("Enter minutes: ");
        min = Convert.ToInt32(Console.ReadLine());

        sec = min * 60;

        Console.WriteLine(sec);
    }
}
