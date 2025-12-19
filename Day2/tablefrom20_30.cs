using System;
class Table
{
    public static void t()
    {
        
        for(int i = 20; i <= 30; i++)
        {
            Console.WriteLine("\nTable of " + i);
            for(int j = 1; j <= 10; j++)
            {
                Console.WriteLine(i+" * "+j+" = "+ (i*j));
            }
            //Console.WriteLine("\n");
        }
    }
}