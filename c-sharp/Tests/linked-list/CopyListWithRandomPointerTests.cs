using System.Collections;

using NUnit.Framework;

namespace Problems.Tests;

public class CopyListWithRandomPointerTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public Node CopyRandomListTest( Node node ) =>
        new CopyListWithRandomPointer().CopyRandomList( node );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData(
                Node
                    .Create( [[7, null], [13, 0], [11, 4], [10, 2], [1, 0]] ) )
                    .Returns( Node.Create( [[7, null], [13, 0], [11, 4], [10, 2], [1, 0]] ) );

            yield return new TestCaseData(
                Node
                    .Create( [[1, 1], [2, 1]] ) )
                    .Returns( Node.Create( [[1, 1], [2, 1]] ) );

            yield return new TestCaseData(
                Node
                    .Create( [[3, null], [3, 0], [3, null]] ) )
                    .Returns( Node.Create( [[3, null], [3, 0], [3, null]] ) );
        }
    }
}
