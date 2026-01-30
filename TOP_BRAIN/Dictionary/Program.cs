using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        Dictionary<int,int> d = new Dictionary<int, int>();
        d.Add(1,20000);
        d.Add(4,40000);
        d.Add(5,15000);
        int s = 0;
        foreach(var i in d)
        {
            s += i.Value;
            
        }
        Console.WriteLine(s);

    }
}