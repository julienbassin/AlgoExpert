using System.Collections.Generic;
using System;
using System.Linq;


public class Program
{

    public string TournamentWinner(List<List<string>> competitions, List<int> results)
    {
        // Write your code here.
        Dictionary<string, int> dic1 = new Dictionary<string, int>();
        for (int i = 0; i < competitions.Count; i++)
        {
            for (int j = 0; j < competitions[i].Count; j++)
            {
                if (!dic1.ContainsKey(competitions[i][j]))
                {
                    dic1.Add(competitions[i][j], 0);
                }
            }
        }

        for (int x = 0; x < results.Count; x++)
        {
            if (results[x] == 1)
            {
                dic1[competitions[x][0]] += 3;
            }
            else
            {
                dic1[competitions[x][1]] += 3;
            }
        }

        var ordered = dic1.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        return ordered.Keys.First();
    }
}

