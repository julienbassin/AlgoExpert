using System.Collections.Generic;
using System;
using System.Linq;


public class Program
{

    public bool ClassPhotos(List<int> redShirtHeights, List<int> blueShirtHeights)
    {
        // Write your code here.
        // sort the 2 array 
        // determine the max of the 2 array and find which array will be in front row ?
        // if a > b then a will be in the back else b
        // if a == b then ou can't take the picture

        redShirtHeights = redShirtHeights.OrderByDescending(v => v).ToList();
        blueShirtHeights = blueShirtHeights.OrderByDescending(v => v).ToList();


        var maxRedShirtHeights = redShirtHeights.Max();
        var maxBlueShirtHeights = blueShirtHeights.Max();
        if (maxRedShirtHeights == maxBlueShirtHeights)
        {
            return false;
        }

        int backRowColor = (maxRedShirtHeights > maxBlueShirtHeights) ? 1 : 0;
        for (int i = 1; i < redShirtHeights.Count(); i++)
        {
            var tallestOfColor = (redShirtHeights[i] > blueShirtHeights[i]) ? 1 : 0;

            if ((redShirtHeights[i] == blueShirtHeights[i]) || (tallestOfColor != backRowColor)) return false;
        }

        return true;

    }
}

