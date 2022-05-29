using System;
using System.Collections.Generic;

public class Program
{
    public static bool IsValidSubsequence(List<int> array, List<int> sequence)
    {
        // Write your code here.

        int sequenceIdx = 0;
        int arrayIdx = 0;
        int count = 0;
        while (arrayIdx < array.Count && sequenceIdx < sequence.Count)
        {
            if (array[arrayIdx] == sequence[sequenceIdx])
            {
                count++;
                sequenceIdx++;
            }
            arrayIdx++;
        }

        return count == sequence.Count;
    }
}