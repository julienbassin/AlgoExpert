using System;

public class Program {
	public static int GetNthFib(int n) {
		// Write your code here.
        int result = 0;
        if(n == 2) return 1;
        else if(n == 1) return 0;
        else {
           result = GetNthFib(n-1) + GetNthFib(n-2) ;
        }
		return result;
	}
}
