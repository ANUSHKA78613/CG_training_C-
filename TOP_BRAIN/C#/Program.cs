using System;
using System.Text;
using System.Linq;
class Program
{
    public static bool IsVowel(char ch)
    {
        return "aeiou".Contains(ch);
    }
    public static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        string secondLower = second.ToLower();
        var filtered = first.Where(ch => IsVowel(char.ToLower(ch)) || !secondLower.Contains(char.ToLower(ch))).ToList();
        var result = filtered.Where((ch,i) => i == 0 || ch != filtered[i-1]);
        Console.WriteLine(new string(result.ToArray()));
    }
}