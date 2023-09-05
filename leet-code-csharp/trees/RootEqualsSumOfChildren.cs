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
