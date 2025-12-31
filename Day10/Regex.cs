using System;
using System.Text.RegularExpressions;
class Reg
{
    public static void Ex()
    {
        // bool result = Regex.IsMatch("abc123",@"\d");
        // Console.WriteLine(result);
        // bool result1 = Regex.IsMatch("11123",@"\D");
        // Console.WriteLine(result1);
        // bool result1 = Regex.IsMatch("_11123",@"\D");
        // Console.WriteLine(result1);
    //    Match m = Regex.Match("Amount:5000",@"\d+");
    //    Console.WriteLine(m.Value);
    //    Match m = Regex.Match("Amount:5000",@"\d*");
    //    Console.WriteLine(m.Value);
    //   MatchCollection matches  = Regex.Matches("10 A 20 30 40",@"\d*");
    //   foreach (Match m in matches)
    //     {
    //         Console.WriteLine(m.Value);
    //     }
    //  Match m  = Regex.Match("10 A 20 30 40",@"\D+");
    //    Console.WriteLine(m);
    //  Match m  = Regex.Match("10 A 20 B 30 40",@"\w");
    //    Console.WriteLine(m);
//    MatchCollection matches = Regex.Matches("10 A 20B 30 40", @"\w+");

// foreach (Match m in matches)
// {
//     Console.WriteLine(m.Value);
// }

// Match m  = Regex.Match("10 20 30a 40B !@_abc _0!",@"\W");
//     Console.WriteLine(m.Value);

//    Match m  = Regex.Match("10 20 30a 40B !@_abc _0! file.txt",@"\s");
//     Console.WriteLine(m);     
//    Match m  = Regex.Match("10 20 30a 40B !@_abc _0! file.txt",@"\.txt");
//     Console.WriteLine(m);  
//  MatchCollection matches = Regex.Matches("C:?\abc\file.txt\\\\?", @"\?");

// foreach (Match m in matches)
// {
//     Console.WriteLine(m);
// }   
//  MatchCollection matches = Regex.Matches("C:?\abc\file.txt\\\\Hello", @"Hello$"); // end of string

// foreach (Match m in matches)
// {
//     Console.WriteLine(m);
// }   
//  MatchCollection matches = Regex.Matches("HelC:?\abc\file.txt\\\\lo", @"^Hello$"); // end of string

// foreach (Match m in matches)
// {
//     Console.WriteLine(m);
// }   

// Match m = Regex.Match("Date:2025-12-29",@"(\d{4})-(\d{2})-(\d{2})");
// Console.WriteLine(m);
// Match m =Regex.Match("23-02-1992,1992-02-23,1990-01-01",@"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})");
// Console.WriteLine(m.Groups["year"].Value);
// Console.WriteLine(m.Groups["month"].Value);
// MatchCollection matches = Regex.Matches("23-02-1992,1992-02-23,1990-01-01,2025",@"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})");
// foreach(Match m in matches)
//         {
//             Console.WriteLine(m.Groups["year"].Value);
//             Console.WriteLine(m.Groups["month"].Value);
//         }

// Match m = Regex.Match("a123e",@"a...e");
// Console.WriteLine(m);
// MatchCollection matches = Regex.Matches("a123e,apples,a!-@e frappe grapple",@"a...e");
//     foreach(Match m in matches)
//         {
//             Console.WriteLine(m);
        
//         }

List<string> Emails = new List<string>
{
    "john.doe@gmail.com",
    "alice_123@yahoo.in",
    "mark.smith@company.com",
    "support-abc@banking.co.in",
    "user.nametag@domain.org",
  "john.doe@gmail",          // Missing domain extension
    "alice@@yahoo.com",        // Double @
    "mark.smith@.com",         // Domain missing name
    "support@banking..com",    // Double dot in domain
    "user name@gmail.com",     // Space not allowed
    "@domain.com",             // Missing username
    "admin@domain",            // No top-level domain
    "info@domain,com",         // Comma instead of dot
    "finance#dept@corp.com",   // Invalid character #
    "plainaddress",          // Missing @ and domain
    "abc@gmail.com.def@yahoo.com"
};

string pattern = @"^[\w.-]+@[\w-]+\.\w{2,}$";
        foreach (string email in Emails)
        {
            if (Regex.IsMatch(email, pattern))
                Console.WriteLine($"VALID   : {email}");
            else
                Console.WriteLine($"INVALID : {email}");
        }
    }
}

