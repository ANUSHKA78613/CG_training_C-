using System;
class Ex
{
    public static void Hand()
    {
        int a = 20,b=0;
        try
        {
            int result = a/b;
        }
        catch(Exception ex)
        {
            Console.WriteLine("error occured: "+ex.Message);
        }
    }
}