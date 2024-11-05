using NUnit.Framework;

using Problems;

public class TwoSumIIInputArrayIsSortedTests
{
    [TestCase( new int[] { 2, 7, 11, 15 }, 9, ExpectedResult = new int[] { 1, 2 } )]
    [TestCase( new int[] { 2, 3, 4 }, 6, ExpectedResult = new int[] { 1, 3 } )]
    [TestCase( new int[] { -1, 0 }, -1, ExpectedResult = new int[] { 1, 2 } )]
    public int[] TwoSumTest( int[] numbers, int target ) =>
        new TwoSumIIInputArrayIsSorted().TwoSum( numbers, target );
}
