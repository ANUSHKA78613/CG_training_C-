using System;
using System.Text.RegularExpressions;
class Assignment
{
    public static void P()
    {
        string input = @"[INFO] 2025-03-21T14:22:19Z service=auth userId=USR_1023 action=LOGIN_SUCCESS
ip=192.168.1.10
[WARN] 2025-03-21T14:22:22Z service=auth userId=USR_2045 passwordTemp123
LOGIN_FAILED
[ERROR] 2025-03-21T14:22:30Z service=payment txnId=TXN998877 amount=₹45,000.50
status=FAILED
[DEBUG] <***> service=payment <===> txnId=TXN112233 amount=$1200 status=SUCCESS
[INFO] ""user passwordReset456 completed successfully""
[CRITICAL] service=db query=""SELECT * FROM users WHERE password='abc123'""
[KUBE] pod=api-gateway-7f9d8 container=nginx restartCount=3";
       Console.WriteLine("Task1");
       string a = @"^\[(INFO|WARN|ERROR|DEBUG|CRITICAL)\] \d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}Z";
       foreach(Match m in Regex.Matches(input, a, RegexOptions.Multiline))
        {
            Console.WriteLine(m.Value);
        }
     Console.WriteLine("Task2");
       string b = @"service=([a-z]+).*?(USR_\d\d+)?";
       
       foreach(Match m in Regex.Matches(input, b))
        {
            Console.WriteLine(m.Value);
        }
     Console.WriteLine("Task3");
       string c =   @"(?i)password[a-z0-9]+|password='[a-z0-9]+'";
       
       foreach(Match m in Regex.Matches(input, c))
        {
            Console.WriteLine(m.Value);
        }

         Console.WriteLine("\nTASK 10: Redacted Logs");
        Console.WriteLine(
            Regex.Replace(
                input,
                @"(?i)password[a-z0-9]+|password='[a-z0-9]+'",
                "***REDACTED***"
            )
        );
                Console.WriteLine("\nTASK 9: Timestamp Validation");
        Console.WriteLine(
            Regex.IsMatch(
                "2025-03-21T14:22:19Z",
                @"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}Z$"
            )
        );

        




    }
}