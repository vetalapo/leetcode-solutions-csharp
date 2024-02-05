using System.Collections;

using NUnit.Framework;

namespace Problems.Tests;

public class CopyListWithRandomPointerTests
{
    [TestCaseSource( nameof( TestCases ) )]
    public Node CopyRandomListTest( Node node ) => new CopyListWithRandomPointer().CopyRandomList( node );

    private static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData( Node.Create( new int?[][]
            {
                new int?[] { 7, null }, new int?[] { 13, 0 }, new int?[] { 11, 4 }, new int?[] { 10, 2 }, new int?[] { 1,0 }
            } ) )
            .Returns( Node.Create( new int?[][]
            {
                new int?[] { 7, null }, new int?[] { 13, 0 }, new int?[] { 11, 4 }, new int?[] { 10, 2 }, new int?[] { 1, 0 }
            } ) );

            yield return new TestCaseData( Node.Create( new int?[][] { new int?[] { 1, 1 }, new int?[] { 2, 1 } } ) )
                .Returns( Node.Create( new int?[][] { new int?[] { 1, 1 }, new int?[] { 2, 1 } } ) );

            yield return new TestCaseData( Node.Create( new int?[][] { new int?[] { 3, null }, new int?[] { 3, 0 }, new int?[] { 3, null } } ) )
                .Returns( Node.Create( new int?[][] { new int?[] { 3, null }, new int?[] { 3, 0 }, new int?[] { 3, null } } ) );
        }
    }
}
