using System;
using System.Collections.Generic;

public class Program
{
    public static bool IsPalindrome(string str)
    {
        // Write your code here.
        Stack<char> stack = new Stack<char>();

        foreach (char currentChar in str)
        {
            stack.Push(currentChar);
        }

        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] != stack.Pop())
            {
                return false; break;
            }
        }

        return true;
    }
}