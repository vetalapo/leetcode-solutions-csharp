using System.Collections.Generic;

using NUnit.Framework;

using Problems;

public class KidsWithTheGreatestNumberOfCandiesTests
{
    [TestCase( new int[] { 2, 3, 5, 1, 3 }, 3, ExpectedResult = new bool[] { true, true, true, false, true } )]
    [TestCase( new int[] { 4, 2, 1, 1, 2 }, 1, ExpectedResult = new bool[] { true, false, false, false, false } )]
    [TestCase( new int[] { 12, 1, 12 }, 10, ExpectedResult = new bool[] { true, false, true } )]
    public IList<bool> KidsWithCandiesTest( int[] candies, int extraCandies ) =>
        new KidsWithTheGreatestNumberOfCandies().KidsWithCandies( candies, extraCandies );
}
