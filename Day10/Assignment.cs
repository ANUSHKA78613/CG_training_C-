using System;
using System.Text.RegularExpressions;
namespace LogProcessing;
class LogParser
{
    private readonly string validLine = @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
    private readonly string splitLine = @"<[\^*=]+>";
    private readonly string quotedPassword ="\".*?password.*?\""; //
    private readonly string endOfLine = @"end-of-line\d+";
    private readonly string weakPassword = @"password[a-zA-z0-9]+";
    public bool isValidLine(string text)
    {
         
        return Regex.IsMatch(text,validLine);
    }

   public string[] SplitLogLine(string text){
   
     return Regex.Split(text,splitLine);
    }

    public int CountQuotedPasswords(string lines)
    {
       return Regex.Matches(lines,quotedPassword,RegexOptions.IgnoreCase).Count;
    }

    public string RemoveEndOfLineText(string line)
    {
      return Regex.Replace(line,endOfLine,"");
    }

    public string[] ListLinesWithPasswords(string[] lines)
    {
        string[] result = new string[lines.Length];
        for(int i = 0; i < lines.Length; i++)
        {
            Match match = Regex.Match(lines[i],weakPassword);
            if (match.Success)
            {
                result[i] = $"{match.Value}:{lines[i]}";
            }
             else
        {
            result[i] = $"--------: {lines[i]}";
        }
        }
        return result;
        
    }


    
}