using System;
using System.Collections.Generic;

public class Program
{

    public bool GenerateDocument(string characters, string document)
    {
        // Write your code here.
        Dictionary<char, int> charactersFrequency = new Dictionary<char, int>();
        for (int i = 0; i < characters.Length; i++)
        {
            if (!charactersFrequency.ContainsKey(characters[i]))
            {
                charactersFrequency.Add(characters[i], 1);
            }
            else
            {
                charactersFrequency[characters[i]] = charactersFrequency[characters[i]] + 1;
            }
        }


        for (int i = 0; i < document.Length; i++)
        {
            if (charactersFrequency.ContainsKey(document[i]) && charactersFrequency[document[i]] > 0)
            {
                charactersFrequency[document[i]] = charactersFrequency[document[i]] - 1;
            }
            else
            {
                return false;
            }

        }
        return true;
    }
}

