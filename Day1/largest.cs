using System;
class Largest
{
    public static void small()
    {
        int a,b,c;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
     if(a > b && a > c)
        {
            Console.Write("A is largest");
        }
        else if( b >= c)
        {
            Console.Write("B is largest");
        }
        else
        {
            Console.Write("C is largest");
        }
    }
}