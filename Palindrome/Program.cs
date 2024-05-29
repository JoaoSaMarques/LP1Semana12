using System;

class Program
{
    static void Main(string[] args)
    {
        foreach (string arg in args)
        {
            Console.WriteLine($"{arg} -> {IsPalindrome(arg)}");
        }
    }

    static bool IsPalindrome(string s)
    {
        if (s == null)
        {
            throw new ArgumentNullException(nameof(s));
        }

        if (s.Length < 2)
        {
            return true;
        }

        return IsPalindromeInternal(s);
    }

    static bool IsPalindromeInternal(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left]!= s[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}