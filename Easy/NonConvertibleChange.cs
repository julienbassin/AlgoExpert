using System;


public class Program {

	public int NonConstructibleChange(int[] coins) {
		// Write your code here.
        if(coins.Length == 0){
            return 1;
        }

        Array.Sort(coins);

        int currentChange = 0;
        
        for(int i = 0; i < coins.Length; i++)
        {
            if(coins[i] > currentChange + 1)
            {                
                break;
            }

            currentChange = currentChange + coins[i];
        }

        return currentChange + 1;
	}
}

