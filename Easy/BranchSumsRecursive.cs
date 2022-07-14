using System;
using System.Collections.Generic;

public class Program
{
    // This is the class of the input root. Do not edit it.
    public class BinaryTree
    {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }

    public static void sumOfDepth(BinaryTree tree, int runningSum, List<int> sumResult)
    {
        if (tree == null)
        {
            return;
        }

        var newResult = runningSum + tree.value;
        if (tree.left == null && tree.right == null)
        {
            sumResult.Add(newResult);
        }

        sumOfDepth(tree.left, newResult, sumResult);
        sumOfDepth(tree.right, newResult, sumResult);

        return;
    }

    public static List<int> BranchSums(BinaryTree root)
    {
        // Write your code here.
        List<int> sum = new List<int>();

        sumOfDepth(root, 0, sum);

        return sum;
    }
}
