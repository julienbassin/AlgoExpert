using System;


public class Program
{

    public int[] SortedSquaredArray(int[] array)
    {
        // Write your code here.
        int[] result = new int[array.Length];
        Array.Sort(array);
        for (int i = 0; i < array.Length; i++)
        {
            int squaredValue = array[i] * array[i];
            result[i] = squaredValue;
        }
        Array.Sort(result);
        return result;
    }

    public int[] SortedSquaredArray(int[] array)
    {
        // Write your code here.
        int[] result = new int[array.Length];
        int smallerValueIdx = 0;
        int largerValueIdx = array.Length - 1;

        for (int i = result.Length - 1; i >= 0; i--)
        {
            if (Math.Abs(array[smallerValueIdx]) > Math.Abs(array[largerValueIdx]))
            {
                result[i] = array[smallerValueIdx] * array[smallerValueIdx];
                smallerValueIdx++;
            }
            else
            {
                result[i] = array[largerValueIdx] * array[largerValueIdx];
                largerValueIdx--;
            }
        }
        return result;
    }
}