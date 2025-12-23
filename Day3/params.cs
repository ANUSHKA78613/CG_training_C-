using System;
class Paras
{
    // params should be at last posiition and not more than 1 params alloowed
    //default should be second last
    public static int Sum( params int[] n)
    {
        int total = 0;
       foreach(int  i in n)
        {
            total += i;  
        }
       
        return total;
     
    }
}