/*
 * 2236
 * Root Equals Sum of Children
 * 
 * You are given the root of a binary tree that consists of exactly 3 nodes: the root, its left child, and its right child.
 * Return true if the value of the root is equal to the sum of the values of its two children, or false otherwise.
 * 
 * Constraints:
 *   The tree consists only of the root, its left child, and its right child.
 *   
 * https://leetcode.com/problems/root-equals-sum-of-children/
 */

using leet_code_csharp.trees.common;

namespace leet_code_csharp.trees;

public class RootEqualsSumOfChildren
{
    public bool CheckTree( TreeNode root )
    {
        if ( root is null || root.left is null || root.right is null )
        {
            return false;
        }

        return root.val == root.left.val + root.right.val;
    }
}
