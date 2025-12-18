using System;
class SS
{
    public static void ss()
    {
        int n = 1234;
        int sum=0;
        while(n > 0)
        {  
            sum = sum *10 +(n%10);
            n /= 10;
        }
        Console.Write(sum);
    }
}