using System;
using System.Collections;

public class Program {

    public static int depthOfNode(BinaryTree tree, int runningDepth)
    {
        if (tree == null)
        {
            return 0;
        }
        
        int left =  depthOfNode(tree.left, runningDepth + 1);
        int right =  depthOfNode(tree.right, runningDepth + 1);

        return runningDepth + left + right;
        
    }
    
	public static int NodeDepths(BinaryTree root) {
		// Write your code here.
		if(root == null)
        {
            return 0;
        }
        return depthOfNode(root, 0);
	}

	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
			left = null;
			right = null;
		}
	}
}
