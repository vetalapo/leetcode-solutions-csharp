using System.Collections;

using NUnit.Framework;

using Problems;
using Problems.Common;


public class SearchInABinarySearchTreeTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public TreeNode SearchBSTTest( TreeNode root, int val ) =>
        new SearchInABinarySearchTree().SearchBST( root, val );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( TreeNode.CreateBST( [4, 2, 7, 1, 3] ), 2 )
                .Returns( TreeNode.CreateBST( [2, 1, 3] ) );
            
            yield return new TestCaseData( TreeNode.CreateBST( [4, 2, 7, 1, 3] ), 5 )
                .Returns( TreeNode.CreateBST( [] ) );
        }
    }
}
