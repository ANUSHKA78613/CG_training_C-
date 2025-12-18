using System;
class S
{
    public static void s()
    {
        int n =1234;
        int sum=0;
        while(n > 0)
        {  
            sum += (n%10);
            n /= 10;
        }
        Console.Write(sum);
    }
}