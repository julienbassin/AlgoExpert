using System;

public class Program
{
    public static int[] TwoNumberSumS1(int[] array, int targetSum)
    {
        // Write your code here.
        int size = array.Length - 1;
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == targetSum)
                {
                    return new int[] { array[i], array[j] };
                }
            }
        }
        return new int[] { };
    }

    public static int[] TwoNumberSum2(int[] array, int targetSum)
    {
        // Write your code here.
        Hashtable result = new Hashtable();
        for (int i = 0; i < array.Length; i++)
        {
            int currentsum = targetSum - array[i];
            if (result.Contains(currentsum))
            {
                return new int[] { currentsum, array[i] };
            }
            else
            {
                result[array[i]] = true;
            }

        }
        return new int[] { };
    }

    public static int[] TwoNumberSumS3(int[] array, int targetSum)
    {
        Array.Sort(array);
        int left = 0;
        int right = array.Length - 1;
        while (left < right)
        {
            int currentsum = array[left] + array[right];
            if (currentsum == targetSum)
            {
                return new int[] { array[left], array[right] };
            }
            else if (currentsum < targetSum)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return new int[] { };
    }
}



