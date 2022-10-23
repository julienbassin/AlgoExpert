using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    // Tip: You can use `el is IList<object>` to check whether an item is a list or
    // an integer.    
    public static int ProductSum(List<object> array, int multiplier = 1)
    {
        // Write your code here.
        int currentSum = 0;
        foreach (var element in array)
        {
            Type tp = element.GetType();
            if (tp.Equals(typeof(int)))
            {
                currentSum += (int)element;
            }
            else if (tp.Equals(typeof(List<object>)))
            {
                currentSum += ProductSum((List<object>)element, multiplier + 1);
            }
        }
        return currentSum * multiplier;
    }
}
