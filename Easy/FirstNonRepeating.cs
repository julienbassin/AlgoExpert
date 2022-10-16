using System;
using System.Collections.Generic;


public class Program
{

    public int FirstNonRepeatingCharacter(string str)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();

        if (str.Length == 0)
        {
            return -1;
        }

        for (int i = 0; i < str.Length; i++)
        {
            var character = str[i];
            if (dic.ContainsKey(character))
            {
                dic[character] = -1;
            }
            else
            {
                dic[character] = i;
            }
        }

        foreach (var DicValue in dic)
        {
            if (DicValue.Value != -1) return DicValue.Value;
        }
        return -1;
    }
}
