using NUnit.Framework;

using Problems;

public class ContiguousArrayTests
{
    [TestCase( new int[] { 0, 1 }, ExpectedResult = 2 )]
    [TestCase( new int[] { 0, 1, 0 }, ExpectedResult = 2 )]
    public int FindMaxLengthTest( int[] nums ) =>
        new ContiguousArray().FindMaxLength( nums );
}
