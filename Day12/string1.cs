using System;
using System.Text;
class St
{
    public static void DD()
    {
        StringBuilder sb = new StringBuilder();
        // sb.Append("Hello").Append("Hello");
        // sb.Append(" ");
        // sb.Append("World");
        // Console.WriteLine(sb.ToString());
        // sb.AppendLine("jiiii");
        // Console.WriteLine(sb.ToString());
        // sb.Insert(13," ");
        // Console.WriteLine(sb.ToString());
        // sb.Remove(0,5);
        // Console.WriteLine(sb.ToString());
        // sb.Replace("jii","Ji");
        // Console.WriteLine(sb.ToString());
        // sb.Clear();
       // Console.WriteLine(GC.GetTotalMemory(false));
        // for(int i = 0; i < 10000; i++)
        // {
        //     sb.Append(i);
        // }
       // tring result = sb.ToString();
       // Console.WriteLine(result);
        // Console.WriteLine(GC.GetTotalMemory(false));
        StringBuilder sb1 = new StringBuilder("Hello");
        StringBuilder sb2 = new StringBuilder("Hello");
        Console.WriteLine(sb1.Equals(sb2));
         StringBuilder sb3 = sb2;
        Console.WriteLine(sb3.Equals(sb2));
        
      //  Console.WriteLine(object.ReferenceEquals(sb3,sb1));
        Console.WriteLine(sb1 == sb2);
        string Str1 = "Hell";
        string Str2 = "Hell";
        // Console.WriteLine(Str1.Equals(Str2));

        // Console.WriteLine(object.ReferenceEquals(Str1,Str2));
    }
}