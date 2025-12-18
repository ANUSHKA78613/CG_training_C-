using System;

class Palindrome
{
    public static void B()
    {
        string s = "LEVEL";
        int st = 0;
        int end = s.Length - 1;
        bool isPalindrome = true;

        while (st < end)
        {
            if (s[st] != s[end])
            {
                isPalindrome = false;
                break;
            }
            st++;
            end--;
        }

        if (isPalindrome)
            Console.Write("Palindrome");
        else
            Console.Write("Not Palindrome");
    }
}
