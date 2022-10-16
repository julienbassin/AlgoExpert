using System;
using System.Collections.Generic;
using System.Text;


public class Program
{
    public string RunLengthEncoding(string str)
    {
        // Write your code here.
        StringBuilder encodedStringCharacters = new StringBuilder();
        int currentRunLength = 1;
        int size = str.Length;
        // loop dic and create string
        for (int i = 1; i < size; i++)
        {
            var currentCharacter = str[i];
            var previousCharacter = str[i - 1];
            if (currentCharacter != previousCharacter ||
                   currentRunLength == 9)
            {

                encodedStringCharacters.Append(currentRunLength);
                encodedStringCharacters.Append(previousCharacter);
                currentRunLength = 0;
            }

            currentRunLength++;
        }

        encodedStringCharacters.Append(currentRunLength);
        encodedStringCharacters.Append(str[size - 1]);

        return encodedStringCharacters.ToString();
    }
}
