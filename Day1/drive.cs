using System;
class Driv{
    public static void E(){
        int age = 22;
        bool hasLicense = true;
        if(age >= 18){
            if(hasLicense){
                  Console.Write("allowed to drive");
            }
            else{
                 Console.Write("License required");
            }
        }
        else{
            Console.Write("Not eligible");
        }
    }
}