using System;
class Calc
{
    // can't be public 
        
    public static void Calculate()
    {
         static void Add(int a,int b)
    {
        Console.WriteLine(a+b);
    }
     static void Sub(int a,int b)
    {
        Console.WriteLine(a-b);
    }
    Add(2,3);
    Sub(56,46);
    }
}