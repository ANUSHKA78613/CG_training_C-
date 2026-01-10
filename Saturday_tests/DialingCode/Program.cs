using System;
using System.Collections.Generic;
using DialingCodesApp;
class Program
{
    public static void Main()
    {
        Console.WriteLine("task1 : ");
        Dictionary<int,string> a1 = DialingCodes.GetEmptyDictionary();
        foreach(var a in a1)
        {
           Console.WriteLine(a.Key + " : "+ a.Value+"\n");  
        }
        
        Console.WriteLine("task 2: ");
        int count = 0;
        Dictionary<int,string> a2 = DialingCodes.GetExistingDictionary();

        foreach(var a in a2)
        {
            count++;
             Console.Write(a.Key + " : "+ a.Value);
             // to add comma
             if(count < a1.Count)
            {
                Console.WriteLine(",");
            }
        }  
         Console.WriteLine("\nTask 3: ");
         foreach(var a in DialingCodes.AddCountryToEmptyDictionary(81, "Japan"))
        {
            Console.WriteLine(a.Key + " : " + a.Value);
        }
         Console.WriteLine("\nTask 4: ");
         foreach(var a in DialingCodes.AddCountryToExistingDictionary(a2,44,"United Kingdom"))
        {
            Console.WriteLine(a.Key + " : " + a.Value);
        }
         Console.WriteLine("\nTask 5: ");
         string s = "";
         s = a2[91];
         Console.WriteLine(a2[91]);
         Console.WriteLine("\nTask 6: ");
         bool m = DialingCodes.CheckCodeExists(a2, 55);
         Console.WriteLine(m);
        DialingCodes.UpdateDictionary(a2, 91, "Republic of India");
           DialingCodes.RemoveCountryFromDictionary(a2, 1);

            // Task 9
            string longest = DialingCodes.FindLongestCountryName(a2);
            Console.WriteLine("Longest Country Name: " + longest);

    }

}