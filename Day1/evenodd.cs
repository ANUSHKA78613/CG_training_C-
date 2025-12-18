using System;
class Even{
    public static void Odd(){
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        if(n % 2 == 0){
            Console.Write("even");
        }
        else{
            Console.Write("odd");
        }
    }
}