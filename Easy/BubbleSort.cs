using System;

public class Program {
	public static int[] BubbleSort(int[] array) {
		// Write your code here.
        var size = array.Length;
        var isSorted = false;

        while(! isSorted)
        {
            isSorted = true;

            for(int i = 1; i < size; i++)
            {
                if(array[i - 1] > array[i]){
                    isSorted = false;
                    var temp = array[i - 1];
                    array[i - 1] = array[i];
                    array[i] = temp;
                }
            }
        }
		return array;
	}
}