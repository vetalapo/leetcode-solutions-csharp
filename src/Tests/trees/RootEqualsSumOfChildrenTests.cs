using System.Collections;

using NUnit.Framework;

using Problems;
using Problems.Common;

[TestFixture]
public class RootEqualsSumOfChildrenTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public bool CheckTreeTest( TreeNode root ) => new RootEqualsSumOfChildren().CheckTree( root );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( new TreeNode( 10, new TreeNode( 4 ), new TreeNode( 6 ) ) ).Returns( true );
            yield return new TestCaseData( new TreeNode( 5, new TreeNode( 3 ), new TreeNode( 1 ) ) ).Returns( false );
            yield return new TestCaseData( new TreeNode( 0, left: null, new TreeNode( 1 ) ) ).Returns( false );
            yield return new TestCaseData( new TreeNode( 0, new TreeNode( 3 ), right: null ) ).Returns( false );
            yield return new TestCaseData( new TreeNode() ).Returns( false );
            yield return new TestCaseData( new TreeNode( 0 ) ).Returns( false );
        }
    }
}