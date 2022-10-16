using System;
using System.Text;

public class Program
{
    public static string CaesarCypherEncryptor(string str, int key)
    {
        StringBuilder caesarCypherString = new StringBuilder();
        //for loop
        int size = str.Length;
        for (int i = 0; i < size; i++)
        {
            key = key % 26;
            // encoding str with ord + key
            var currentCharEncoded = (int)str[i] + key;
            // if strEncoded <= 122
            if (currentCharEncoded <= 122)
            {
                // return chr(str)
                caesarCypherString.Append((char)currentCharEncoded);
            }
            else
            {
                // return chr(96 + strEncoded % 122)
                caesarCypherString.Append((char)(96 + currentCharEncoded % 122));
            }
        }

        return caesarCypherString.ToString();
    }
}
