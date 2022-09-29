using System;


public class Program {

	public int MinimumWaitingTime(int[] queries) {
		// Write your code here.
        int totalWaitingTime = 0;
        Array.Sort(queries);

        if(queries.Length == 1){
            return totalWaitingTime;
        }

        if(queries.Length <= 2){
            return totalWaitingTime += 0 + queries[0];
        }
        int size = queries.Length - 1;
        for(int i=0; i < queries.Length; i++)
        {
            // 1 2 2 3 6
            // 4 6 3 5 8 = 17
            
            totalWaitingTime += size * queries[i];
            size -= 1;
        }
		return totalWaitingTime;
	}
}

