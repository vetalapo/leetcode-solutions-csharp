using System.Collections.Generic;

using NUnit.Framework;

using Problems;

public class FindIndicesOfStableMountainsTests
{
    [TestCase( new int[] { 1, 2, 3, 4, 5 }, 2, ExpectedResult = new int[] { 3, 4 } )]
    [TestCase( new int[] { 10, 1, 10, 1, 10 }, 3, ExpectedResult = new int[] { 1, 3 } )]
    [TestCase( new int[] { 10, 1, 10, 1, 10 }, 10, ExpectedResult = new int[] { } )]
    public IList<int> StableMountainsTest( int[] height, int threshold ) =>
        new FindIndicesOfStableMountains().StableMountains( height, threshold );
}
